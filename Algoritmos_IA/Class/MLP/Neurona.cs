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

        public Neurona() 
        {
            
        }

        public void inicializaPesos(int entradas) 
        {
            Random r = new Random();
            for (int i = 0; i < entradas; i++) 
            {
                if (i == 0)
                {
                    pesos.Add(-1);
                }
                else
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
}
