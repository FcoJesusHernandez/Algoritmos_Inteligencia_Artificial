using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Algoritmos_IA.Class
{
    public class Clases
    {
        Color Color_Pluma;

        int Dureza;
        List<int> lista_colores;
        Random Color_random;
        public Clases(Random random)
        {
            Color_random = random;
            Color_Pluma = new Color();
            Dureza = 2;
            lista_colores = new List<int>();
        }
        public Pen get_Pluma()
        {
            
            int suma = 0;
            while (suma < 300)
            {
                suma = 0;
                lista_colores.Clear();
                for (int i = 0; i < 3; i++)
                {
                    lista_colores.Add(Color_random.Next(0, 255));
                }
                foreach (int i in lista_colores)
                {
                    suma += i;
                }
            }

            Color_Pluma = Color.FromArgb(lista_colores[0], lista_colores[1], lista_colores[2]);
            Console.WriteLine(Color_Pluma);
            Pen Pluma = new Pen(Color_Pluma, Dureza );
            return Pluma;
        }

        public void funcion_prueba()
        {
            Console.WriteLine("funciona");
        }
    }
}
