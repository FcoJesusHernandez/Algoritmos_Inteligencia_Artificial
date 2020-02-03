using System;
using System.Windows.Forms;

public class Punto
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

    private void adaptarPunto()
    {
        posicion_adaptada_x = ((float)posicion_original_x - 150) / 30;
        if (posicion_adaptada_x < 0)
        {
            posicion_adaptada_x = posicion_adaptada_x * -1;
        }

        posicion_adaptada_y = ((float)posicion_original_y - 150) / 30;
        if (posicion_adaptada_y < 0)
        {
            posicion_adaptada_y = posicion_adaptada_y * -1;
        }

        if (posicion_original_x <= 150 && posicion_original_y <= 150)
        {
            posicion_adaptada_x = posicion_adaptada_x * -1;
        }
        else if (posicion_original_x <= 300 && posicion_original_y <= 150)
        {
            posicion_adaptada_y = (150 - (float)posicion_original_y) / 30;
            if (posicion_adaptada_y < 0)
            {
                posicion_adaptada_y = posicion_adaptada_y * -1;
            }
        }
        else if (posicion_original_x <= 150 && posicion_original_y <= 300)
        {
            posicion_adaptada_x = posicion_adaptada_x * -1;
            posicion_adaptada_y = posicion_adaptada_y * -1;
        }
        else if (posicion_original_x <= 300 && posicion_original_y <= 300)
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
}
