using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSharp;

namespace Algoritmos_IA.Class.MLP
{
    class MLP
    {
        List<Punto> entradas;
        List<Capa> capas;
        bool primerForward = true;
        NDArray matrizDeseadas;
        float learningRate;
        int epocas;
        double errorAcumulado;

        public MLP(int epocas, int nCapas, List<int> neuronaXCapa, float lr, List<Punto> puntos)
        {
            this.epocas = epocas;
            this.entradas = puntos;
            this.entradas = puntos;
            this.learningRate = lr;
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
            return sigmoide*(1-sigmoide);
        }

        public void Forward_Backward() 
        {
            for(int i = 0; i < epocas; i++) 
            {
                //if error
                errorAcumulado = 0;
                foreach (Punto p in entradas)
                {
                    Forward(p, false);
                    BackPropagation(p);
                }
                Console.WriteLine("Error Acumulado por Epoca: ");
                Console.WriteLine(errorAcumulado / entradas.Count);
            }
        }
        public void Forward( Punto p, bool evaluar) 
        {
            double[,] primerEntrada= new double[3,1];
            if (evaluar)
            {
                primerEntrada[0, 0] = -1;
                primerEntrada[1, 0] = p.getPosicionOriginalX();
                primerEntrada[2, 0] = p.getPosicionOriginalY();
            }
            else 
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

                /*NDArray uno = new NDArray(typeof(Double), new Shape(3, 1));
                NDArray dos = new NDArray(typeof(Double), new Shape(1, 3));
                Random r = new Random();
                for (int i = 0; i < 3; i++) 
                {
                    uno[i, 0] = r.Next();
                    dos[0, i] = r.Next();
                }
                var tres = np.dot(dos, uno);*/

                net = np.dot(c.getPesosCapa(), entrada);

                c.netCapa = net;

                double[,] a_salida = new double[net.size, 1];

                for (int i = 0; i < net.size; i++)
                {
                    a_salida[i, 0] = net[i, 0];
                }
                c.salidaCapa = a_salida;

                double[,] bias =new double[1,1];

                bias[0, 0] = -1;

                NDArray s = np.vstack( bias, a_salida );

                entrada = s;

                if (evaluar && capas.Last<Capa>()==c)
                {
                    Console.WriteLine("C: "+c.salidaCapa.ToString());
                }
            }
            primerForward = false;
        }

        public void BackPropagation(Punto p) 
        {
            bool primerCapa = true;
            
            capas.Reverse();

            Capa anterior=capas.First<Capa>();

            foreach (Capa c in capas)
            {
                
                if (primerCapa)
                {
                    NDArray deseada = new NDArray((Array)matrizDeseadas[p.getTipo()],new Shape(matrizDeseadas.Shape[0],1));
                    var error = np.subtract(deseada, c.salidaCapa);
                    double acum = 0;
                    for (int i = 0; i < error.size; i++)
                    {
                        acum += error[i][0];
                    }
                    errorAcumulado += Math.Pow(acum, 2);
                    NDArray gradiente = new NDArray(typeof(Double), new Shape(c.netCapa.size, 1));
                    for (int i = 0; i < c.netCapa.size; i++)
                    {
                        gradiente[i,0]=funcion_sigmoide_derivada(c.netCapa[i,0]);
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
