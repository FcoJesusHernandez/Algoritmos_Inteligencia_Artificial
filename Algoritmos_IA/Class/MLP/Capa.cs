using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSharp;

namespace Algoritmos_IA.Class.MLP
{
    public class Capa
    {
        public List<Neurona> listaNeuronas { set; get; }
        public NDArray netCapa { set; get; }
        public NDArray pesos { set; get; }
        public NDArray salidaCapa { set; get; }

        public NDArray sensibilidadCapa { set; get; }
        Img_control ImgControl;

        public NDArray gradienteAnterior { set; get; }
        public NDArray W_Anterior { set; get; }

        static Random r = new Random();

        public Boolean llegoLimite { set; get; }

        private int contllegoLim;
        public Capa(int nNeuronas)
        {
            //ImgControl = imgC;
            llegoLimite = false;
            contllegoLim = 0;
            listaNeuronas = new List<Neurona>();
            for (int i = 0; i < nNeuronas; i++)
            {
                Neurona n = new Neurona();
                this.listaNeuronas.Add(n);
            }
        }

        public void setImgControl(Img_control ImgC)
        {
            ImgControl = ImgC;
        }

        public NDArray getPesosCapa()
        {
            pesos = new NDArray(typeof(Double));
            NDArray pesosNeurona = new NDArray(typeof(Double));
            foreach (Neurona a in listaNeuronas)
            {
                pesosNeurona = a.pesos.ToArray();
                if (pesos.size == 0)
                {
                    pesos = new NDArray((Array)pesosNeurona, new Shape(1,a.pesos.Count));
                }
                else
                {
                    pesos = np.vstack(new NDArray[] { pesos, pesosNeurona });
                }
            }
            /*Console.WriteLine(pesos.ToString());*/
            return pesos;
        }
        public NDArray getPesosSinCero() 
        {
            var transpuesta = np.transpose(pesos);
            NDArray pesosSinCero = new NDArray(typeof(Double));
            NDArray fila = new NDArray(typeof(Double));
            for (int i = 1; i < transpuesta.Shape[0]; i++) 
            {
                fila = transpuesta[i];
                if (pesosSinCero.size == 0)
                {
                    pesosSinCero = new NDArray((Array)fila, new Shape(1, transpuesta.Shape[1]));
                }
                else 
                {
                    pesosSinCero= np.vstack(new NDArray[] { pesosSinCero, transpuesta[i] });
                }
            }
            return pesosSinCero;   
        }
        public void actualizaPesos(float lr, NDArray a) 
        {
            var s_a = np.dot(sensibilidadCapa, np.transpose(a));
            var w_incremento = np.dot(-lr, s_a);
            pesos = pesos + w_incremento;
            //Console.WriteLine(pesos.ToString());
            
            //Console.WriteLine(pesos[0].ToString());
            NDArray pesosNeurona = new NDArray(typeof(Double));
            for (int i = 0; i < pesos.Shape[0];i++) 
            {
                listaNeuronas[i].pesos = new List<double>();

                for (int j = 0; j < pesos.Shape[1]; j++) 
                {
                    if (pesos.Shape[1] == 3)
                    {
                        if (j < pesos.Shape[1])
                        {
                            //ImgControl.DibujarLinea(false, "MLP", pesos[i], true);
                        }
                        //ImgControl.DibujarLinea(false, "MLP", pesos[i], false);
                    }
                    listaNeuronas[i].pesos.Add(pesos[i][j]);
                }
            }
        }

        public void QuickActualizaPesos(NDArray a)
        {
            NDArray matrizW = new NDArray(typeof(Double), new Shape(pesos.Shape[0], pesos.Shape[1]));
            NDArray matrizGradientes = new NDArray(typeof(Double), new Shape(pesos.Shape[0], pesos.Shape[1]));

            for (int i = 0; i < pesos.Shape[0]; i++)
            {
                listaNeuronas[i].pesos = new List<double>();

                for (int j = 0; j < pesos.Shape[1]; j++)
                {
                    double E_gradiente = gradienteError(sensibilidadCapa[i][0], a[j][0]);
                    matrizGradientes[i, j] = E_gradiente;
                    double incW = incremento_W(i, j, E_gradiente);
                    if (incW > (1.75 * (double)W_Anterior[i, j]))
                    {
                        incW = 1.75 * W_Anterior[i, j];
                    }
                    if (gradienteAnterior[i, j] * E_gradiente >= 0) 
                    {
                        incW += 0.03 * E_gradiente;
                    }

                    if (incW > (Double.MaxValue/2)) // !Double.IsNaN(incW) || 
                    {
                        matrizW[i, j] = incW;
                        pesos[i, j] += incW;
                    } else
                    {
                        contllegoLim++;
                        if(contllegoLim == 20)
                        {
                            llegoLimite = true;
                        }
                    }
                    
                    listaNeuronas[i].pesos.Add(pesos[i, j]);
                }
            }
            gradienteAnterior = matrizGradientes;

            W_Anterior = matrizW;
        }

        public double gradienteError(double s, double a)
        {
            return (s * a);
        }

        public double incremento_W(int i, int j, double E_gradiente)
        {
            if ((gradienteAnterior[i, j] - E_gradiente) == 0) 
            {
                return 0.1;
            }
            return ((E_gradiente / (gradienteAnterior[i, j] - E_gradiente)) * W_Anterior[i, j]);
        }

        public void inicializaAnteriores()
        {
            gradienteAnterior = new NDArray(typeof(Double), new Shape(pesos.Shape[0], pesos.Shape[1]));
            W_Anterior = new NDArray(typeof(Double), new Shape(pesos.Shape[0], pesos.Shape[1]));
            for (int i = 0; i < pesos.Shape[0]; i++)
            {

                for (int j = 0; j < pesos.Shape[1]; j++)
                {
                    gradienteAnterior[i, j] = r.NextDouble();
                    W_Anterior[i, j] = r.NextDouble()+0.01;
                }
            }
        }
        public double abs(double wa)
        {
            if (wa < 0) 
            {
                wa = wa * -1;
            }
            return wa;
        }
    }
}
