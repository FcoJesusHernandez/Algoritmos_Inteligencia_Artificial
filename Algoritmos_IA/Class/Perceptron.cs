using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_IA.Class
{
    class Perceptron
    {
        float[] w;
        Punto[] puntos;
        int epocas;
        float LR;
        bool entrenado;
        public Perceptron(int epocas, float LR, Punto[] puntosEntrenamiento)
        {
            entrenado = false;
            this.epocas = epocas;
            this.LR = LR;
            this.puntos = puntosEntrenamiento;

            int[] wTemp = { int.Parse(puntosEntrenamiento[0].ToString()), int.Parse(puntosEntrenamiento[1].ToString()), int.Parse(puntosEntrenamiento[4].ToString()) };
        }

        private int error(int tipo, int salida_calculada)
        {
            return 1;
        }

        private int funcionEscalon(int x)
        {
            return 1;
        }

        public int getEpocas()
        {
            return epocas;
        }

        public bool getEntrenado()
        {
            return entrenado;
        }
    }
}
