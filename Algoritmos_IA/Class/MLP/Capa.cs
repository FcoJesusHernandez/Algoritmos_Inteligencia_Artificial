using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_IA.Class.MLP
{
    public class Capa
    {
        public List<Neurona> listaNeuronas { get; }

        public Capa(int nNeuronas) 
        {
            for (int i = 0; i < nNeuronas; i++) 
            {
                Neurona n;
                n = new Neurona();
                listaNeuronas.Add(n);
            }
        }




    }
}
