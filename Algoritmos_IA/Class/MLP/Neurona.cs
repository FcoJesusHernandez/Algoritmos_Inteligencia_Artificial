using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_IA.Class.MLP
{
    public class Neurona
    {
        public List<Double> pesos { get; set; }
        public Double sensibilidad { get; set; }
        public Double salida { get; set; }

        static Random r = new Random();

        public Neurona() 
        {
            pesos = new List<Double>();
        }

        public void inicializaPesos(int entradas) 
        {
            for (int i = 0; i < entradas; i++) 
            {
                
                    if (r.Next(0, 50) > 25)
                    {
                        pesos.Add(r.NextDouble() * -1);
                    }
                    else
                    {
                        pesos.Add(r.NextDouble());
                    }
                
            }
        }

    }
}
