using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSharp;
using System.Windows.Forms;
using System.Drawing;


namespace Algoritmos_IA.Class.MLP
{
    public class MLP : Form1
    {
        Img_control ImgControl;
        List<Punto> entradas;
        List<Capa> capas;
        List<NDArray> combinacion_clases;
        List<int> relacion_numero_clase;
        bool primerForward = true;
        NDArray matrizDeseadas;
        float learningRate;
        int epocas;
        double errorAcumulado;
        double errorDeseado;

        public MLP(int epocas, int nCapas, List<int> neuronaXCapa, float lr, List<Punto> puntos, double errorDeseado)
        {
            combinacion_clases = new List<NDArray>();
            relacion_numero_clase = new List<int>();

            this.epocas = epocas;
            this.entradas = puntos;
            this.entradas = puntos;
            this.learningRate = lr;
            this.errorDeseado = errorDeseado;
            capas = new List<Capa>();
            for (int i = 0; i < nCapas; i++)
            {
                Capa c;
                c = new Capa(neuronaXCapa[i]);
                capas.Add(c);
            }
            matrizDeseadas = np.eye(neuronaXCapa[nCapas - 1]);
        }

        public double funcion_sigmoide(double net)
        {
            return 1 / (1 + (Math.Exp(-net)));
        }

        public double funcion_sigmoide_derivada(double net)
        {
            double sigmoide = funcion_sigmoide(net);
            return sigmoide * (1 - sigmoide);
        }

        public async Task Forward_Backward(Bitmap bitmap_plano, Bitmap respaldo,Bitmap bitmap_solo_plano, Form callingForm, List<Pen> plumas, List<Punto> lista_puntos, Boolean LineasSwitch)
        {
            ImgControl = new Img_control(bitmap_plano, respaldo, bitmap_solo_plano, plumas, callingForm);
            foreach (Capa c in capas)
            {
                c.setImgControl(ImgControl);
            }
            ImgControl.LimpiarPLano();

            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < epocas; i++)
                {
                    if (errorDeseado > ( errorAcumulado / entradas.Count ) && i != 0)
                    {
                        //Console.WriteLine("Error Acumulado por Epoca: ");
                        //Console.WriteLine(errorAcumulado / entradas.Count);
                        break;
                    }

                    if (i == 100) 
                    {
                        Console.WriteLine("XD: "+funcion_sigmoide(0));
                    }
                    errorAcumulado = 0;

                    combinacion_clases = new List<NDArray>();
                    relacion_numero_clase = new List<int>();

                    foreach (Punto p in entradas)
                    {
                        Forward(p, false, false);
                        BackPropagation(p);
                    }
                    //Console.WriteLine("Error Acumulado por Epoca: ");
                    Console.WriteLine(errorAcumulado);
                    //Console.WriteLine("Epoca: " + epocas.ToString());
                    ImgControl.ActualizarGraficaError("MLP", i, errorAcumulado);
                }
                combinacion_clases = new List<NDArray>();
                relacion_numero_clase = new List<int>();

                // definir clases
                foreach (Punto p in entradas)
                {
                    if (!relacion_numero_clase.Contains(p.getTipo()))
                    {
                        Forward(p, true, true);
                    }
                }

                //Dibuajar el area bajo la curva
                ImgControl.Dibujar_bitmap_mlp(this, lista_puntos);

                ImgControl.Plano_Paint();
                // Dibujar las rectas al final

                if (LineasSwitch == true)
                {
                    for (int i = 0; i < capas[0].pesos.Shape[0]; i++)
                    {
                        capas[0].listaNeuronas[i].pesos = new List<double>();

                        for (int j = 0; j < capas[0].pesos.Shape[1]; j++)
                        {
                            if (capas[0].pesos.Shape[1] == 3)
                            {
                                Console.WriteLine(i);
                                ImgControl.DibujarLinea(true, "MLP", capas[0].pesos[i], true);
                            }
                            capas[0].listaNeuronas[i].pesos.Add(capas[0].pesos[i][j]);
                        }
                    }
                }

                //ImgControl.DibujarPuntos(plumas, lista_puntos);
            });
        }

        public int Forward(Punto p, bool evaluar, bool guardar_clase)
        {
            double[,] primerEntrada = new double[3, 1];
            //Este if y el bool evaluar es solo para los casos de prueba, hay que quitarlos
            if (evaluar)
            {
                primerEntrada[0, 0] = -1;
                /*primerEntrada[1, 0] = p.getPosicionOriginalX();
                primerEntrada[2, 0] = p.getPosicionOriginalY();*/
                primerEntrada[1, 0] = p.getPosicionAdaptadaX();
                primerEntrada[2, 0] = p.getPosicionAdaptadaY();
            }
            else //lo que esta en este else si se ocupa
            {
                primerEntrada[0, 0] = -1;
                primerEntrada[1, 0] = p.getPosicionAdaptadaX();
                primerEntrada[2, 0] = p.getPosicionAdaptadaY();
            }

            NDArray net;
            NDArray entrada = new NDArray(primerEntrada);

            foreach (Capa c in capas)
            {
                if (primerForward)
                {
                    foreach (Neurona a in c.listaNeuronas)
                    {
                        a.inicializaPesos(entrada.size);
                    }
                }
                else if (!evaluar)
                {
                    c.actualizaPesos(learningRate, entrada);
                }

                net = np.dot(c.getPesosCapa(), entrada);

                c.netCapa = net;

                double[,] a_salida = new double[net.size, 1];

                for (int i = 0; i < net.size; i++)
                {
                    a_salida[i, 0] = funcion_sigmoide(net[i, 0]);
                }
                c.salidaCapa = a_salida;

                double[,] bias = new double[1, 1];

                bias[0, 0] = -1;

                NDArray s = np.vstack(bias, a_salida);

                entrada = s;

                //Esta parte creo que conviene hacerla una funciona aparte, para que devuelva el valor de la clase

                if (guardar_clase && capas.Last<Capa>() == c)
                {
                    NDArray temp_combinacion = new NDArray((double[,])c.salidaCapa);

                    for (int i = 0; i < temp_combinacion.Shape[0]; i++)
                    {
                        if (temp_combinacion[i][0] >= 0.5)
                        {
                            temp_combinacion[i][0] = 1;
                        }
                        else
                        {
                            temp_combinacion[i][0] = 0;
                        }
                    }

                    if (!combinacion_clases.Contains(temp_combinacion))
                    {
                        combinacion_clases.Add(temp_combinacion);
                        relacion_numero_clase.Add(p.getTipo());
                    }
                }

                if (evaluar && capas.Last<Capa>() == c)
                {
                    Console.WriteLine("C_salida: " + c.salidaCapa.ToString());

                    int clase = -1;
                    for (int i = 0; i < c.salidaCapa.Shape[0]; i++)
                    {
                        if (c.salidaCapa[i][0] >= 0.5)
                        {
                            c.salidaCapa[i][0] = 1;
                        }
                        else
                        {
                            c.salidaCapa[i][0] = 0;
                        }
                    }

                    for (int i = 0; i < combinacion_clases.Count; i++)
                    {
                        int coincidencias = 0;
                        for (int j = 0; j < combinacion_clases[i].size; j++)
                        {
                            if (combinacion_clases[i][j][0] == c.salidaCapa[j][0])
                            {
                                coincidencias++;
                            }
                        }
                        if(coincidencias == combinacion_clases[i].size)
                        {
                            clase = relacion_numero_clase[i];
                            //Console.WriteLine("C: " + c.salidaCapa.ToString());
                            //Console.WriteLine("Clase: " + clase.ToString());
                            return clase;
                        }
                    }
                }
                //
            }
            
            primerForward = false;
            return 0;
        }

        public void BackPropagation(Punto p)
        {
            bool primerCapa = true;

            capas.Reverse();

            Capa anterior = capas.First<Capa>();

            foreach (Capa c in capas)
            {

                if (primerCapa)
                {
                    NDArray deseada = new NDArray((Array)matrizDeseadas[p.getTipo()], new Shape(matrizDeseadas.Shape[0], 1));
                    var error = np.subtract(deseada, c.salidaCapa);
                    double acum = 0;
                    for (int i = 0; i < error.size; i++)
                    {
                        acum += Math.Pow(error[i][0],2);
                    }
                    errorAcumulado += acum/ 2;
                    NDArray gradiente = new NDArray(typeof(Double), new Shape(c.netCapa.size, 1));
                    for (int i = 0; i < c.netCapa.size; i++)
                    {
                        gradiente[i, 0] = funcion_sigmoide_derivada(c.netCapa[i, 0]);
                    }
                    var s = np.multiply(-2, gradiente);
                    var sensibilidad = np.multiply(s, error);
                    c.sensibilidadCapa = sensibilidad;
                    anterior = c;
                    primerCapa = false;
                }
                else
                {
                    NDArray gradiente = new NDArray(typeof(Double), new Shape(c.netCapa.size, 1));
                    for (int i = 0; i < c.netCapa.size; i++)
                    {
                        gradiente[i, 0] = funcion_sigmoide_derivada(c.netCapa[i, 0]);
                    }
                    var unos = np.eye(gradiente.size);
                    var identidad = np.multiply(gradiente, unos);
                    var transpuesta = anterior.getPesosSinCero();
                    var ws = np.dot(transpuesta, anterior.sensibilidadCapa);
                    var sensibilidad = np.dot(identidad, ws);
                    c.sensibilidadCapa = sensibilidad;
                    anterior = c;
                }
            }
            capas.Reverse();
        }
    }
}
