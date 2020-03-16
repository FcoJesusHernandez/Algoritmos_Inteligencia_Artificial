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
        public Capa(int nNeuronas)
        {
            listaNeuronas = new List<Neurona>();
            for (int i = 0; i < nNeuronas; i++)
            {
                Neurona n = new Neurona();
                this.listaNeuronas.Add(n);
            }
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
                    pesos = pesosNeurona;
                }
                else
                {
                    pesos = np.vstack(new NDArray[] { pesos, pesosNeurona });
                }
            }
            return pesos;
        }
        public NDArray getPesosSinCero()
        {
            var transpuesta = np.transpose(pesos);
            NDArray pesosSinCero = new NDArray(typeof(Double));
            for (int i = 1; i < transpuesta.Shape[0]; i++)
            {
                if (pesosSinCero.size == 0)
                {
                    pesosSinCero = transpuesta[i];
                }
                else
                {
                    pesosSinCero = np.vstack(new NDArray[] { pesosSinCero, transpuesta[i] });
                }
            }
            return pesosSinCero;
        }
        public void actualizaPesos(float lr, double[] a)
        {
            var s_a = np.multiply(sensibilidadCapa, np.transpose(a));
            var w_incremento = np.multiply(-lr, s_a);
            pesos = pesos + w_incremento;
        }
    }
}
