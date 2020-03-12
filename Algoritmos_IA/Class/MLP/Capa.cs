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
                    pesos = new NDArray((Array)pesosNeurona, new Shape(1,a.pesos.Count));
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
            NDArray pesosNeurona = new NDArray(typeof(Double));
            for (int i = 0; i < pesos.Shape[0];i++) 
            {
                listaNeuronas[i].pesos = new List<double>();

                for (int j = 0; j < pesos.Shape[1]; j++) 
                {
                    listaNeuronas[i].pesos.Add(pesos[i][j]);
                }
            }
        }
    }
}
