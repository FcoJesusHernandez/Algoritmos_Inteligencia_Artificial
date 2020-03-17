using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_IA.Class
{
    class Punto
    {
        private int posicion_original_x, posicion_original_y;
        private float posicion_adaptada_x, posicion_adaptada_y;
        private int tipo;

        public Punto(int o_x, int o_y, int t)
        {
            posicion_original_x = o_x;
            posicion_original_y = o_y;
            tipo = t;

            adaptarPunto();
        }

        public Punto(float adaptada_x, float adaptada_y, int t, int o_x, int o_y)
        {
            posicion_adaptada_x = adaptada_x;
            posicion_adaptada_y = adaptada_y;
            tipo = t;

            posicion_original_x = o_x;
            posicion_original_y = o_y;
        }

        private void adaptarPunto()
        {
            posicion_adaptada_x = ((float)posicion_original_x - 300) / 60;
            if (posicion_adaptada_x < 0)
            {
                posicion_adaptada_x = posicion_adaptada_x * -1;
            }

            posicion_adaptada_y = ((float)posicion_original_y - 300) / 60;
            if (posicion_adaptada_y < 0)
            {
                posicion_adaptada_y = posicion_adaptada_y * -1;
            }

            if (posicion_original_x <= 300 && posicion_original_y <= 300)
            {
                posicion_adaptada_x = posicion_adaptada_x * -1;
            }
            else if (posicion_original_x <= 600 && posicion_original_y <= 300)
            {
                posicion_adaptada_y = (300 - (float)posicion_original_y) / 60;
            }
            else if (posicion_original_x <= 300 && posicion_original_y <= 600)
            {
                posicion_adaptada_x = posicion_adaptada_x * -1;
                posicion_adaptada_y = posicion_adaptada_y * -1;
            }
            else if (posicion_original_x <= 600 && posicion_original_y <= 600)
            {
                posicion_adaptada_y = posicion_adaptada_y * -1;
            }
        }

        public int getPosicionOriginalX()
        {
            return posicion_original_x;
        }

        public int getPosicionOriginalY()
        {
            return posicion_original_y;
        }

        public float getPosicionAdaptadaX()
        {
            return posicion_adaptada_x;
        }

        public float getPosicionAdaptadaY()
        {
            return posicion_adaptada_y;
        }

        public int getTipo()
        {
            return tipo;
        }

        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }
    }
}
