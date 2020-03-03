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
        Color Color_Pluma = new Color();
        Pen Pluma;
        int Dureza = 5;
        List<int> lista_colores = new List<int>();
        public Clases()
        {
            Generador_Plumas();
        }
        public void Generador_Plumas()
        {
             
            Random Color_random = new Random();
            int suma = 0;
            while (suma < 300)
            {
                suma = 0;
                for (int i = 0; i < 3; i++)
                {
                    Color_random.Next(0, 255);
                }
                foreach (int i in lista_colores)
                {
                    suma += i;
                }
            }

            Color_Pluma = Color.FromArgb(lista_colores[0], lista_colores[1], lista_colores[2]);
            Pen Pluma = new Pen(Color_Pluma, Dureza );
        }

        public Pen getPluma()
        {
            return Pluma;
        }
    }
}
