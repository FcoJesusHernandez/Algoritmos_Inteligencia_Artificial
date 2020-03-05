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

        public MLP(int nCapas, List<int> neuronaXCapa)
        {
            for (int i = 0; i < nCapas; i++)
            {
                Capa c;
                c = new Capa(neuronaXCapa[i]);
                capas.Add(c);
            }
        }

        public double funcion_sigmoide(int net)
        {
            return 1 / (1 + (Math.Exp(-net)));
        }

        public void Forward() 
        {
            foreach (Punto p in entradas)
            {
                double[] entrada;
                entrada = new double[3];
                entrada[0] = -1;
                entrada[1] = p.getPosicionAdaptadaX();
                entrada[2] = p.getPosicionAdaptadaY();

                NDArray net;
                NDArray pesosCapa = new NDArray(typeof(Double));
                //NDArray pesoCapa = new double[];

                foreach (Capa c in capas)
                {

                    Array pesosNeurona;
                    pesosNeurona = (Array)np.zeros(entrada.Length);
                    foreach (Neurona a in c.listaNeuronas)
                    {
                        a.inicializaPesos(entrada.Length);
                        pesosNeurona = a.pesos.ToArray();

                    }
                    pesosCapa = np.vstack(pesosNeurona);

                    net = np.multiply(pesosCapa, entrada);

                    List<Double> a_salida = new List<Double>();

                    for (int i = 0; i < net.Shape[0]; i++)
                    {
                        a_salida.Add(funcion_sigmoide(net[i][0]));
                    }
                    entrada = a_salida.ToArray();

                    Console.WriteLine("Salidas: " + entrada);

                }

                

                

            }
        }
    }
}
