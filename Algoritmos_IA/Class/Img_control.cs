using System;
//using Algoritmos_IA.Class.MLP;
//using Algoritmos_IA.Class;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using NumSharp;

namespace Algoritmos_IA.Class
{
    public class Img_control : Form
    {
        private Form1 mainForm = null;
        Bitmap bitmap_plano, respaldo, bitmap_solo_plano;
        List<Pen> plumas;
        public Img_control(Bitmap newBitmap, Bitmap newBitmap2, Bitmap newBitmap3, List<Pen> listaPlumas, Form CallingForm)
        {
            plumas = listaPlumas;
            mainForm = CallingForm as Form1;
            bitmap_plano = new Bitmap(newBitmap);
            respaldo = new Bitmap(newBitmap2);
            bitmap_solo_plano = new Bitmap(newBitmap3);
        }

        public void LimpiarPLano()
        {
            this.mainForm.ImagePlano = bitmap_plano;
        }

        public void DibujarPuntos(List<Pen> plumas, List<Punto> ListPoints)
        {
            Graphics bitmap_temp = Graphics.FromImage(bitmap_plano);
            Graphics bitmap_temp_respaldo = Graphics.FromImage(respaldo);
            //Pen pluma;

            foreach (Punto p in ListPoints)
            {
                Pen pluma = plumas[p.getTipo()]; //new Pen(Color.Green, 3);

                bitmap_temp.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
                //bitmap_temp_respaldo.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));

                //plano.Image = bitmap_plano;
                //plano.Refresh();

            }
            this.mainForm.ImagePlano = bitmap_plano;
        }

        public void DibujarLinea(bool definitivo, string type, NDArray n, bool DibujarBitmap)
        {
            Bitmap bm_temp;
            Color color_pen;
            if (definitivo)
            {
                bm_temp = bitmap_plano;
            }
            else
            {
                bm_temp = new Bitmap(bitmap_plano);
            }

            Graphics bitmap_temp = Graphics.FromImage(bm_temp);

            Array x = (Array)np.zeros(10);
            Array y = (Array)np.zeros(10);

            
            for (int i = 0, j = -5; i < 10; i++, j++)
            {
                x.SetValue(j, i);
                //y.SetValue(-(double)n[0][0] , i);
                //Console.WriteLine((double)n[0]);
                y.SetValue((-(double)n[0] + (double)n[1] * (double)x.GetValue(i)) / (double)n[2], i);
                /*
                if (type == "perceptron")
                {
                    
                }
                else if (type == "adaline")
                {
                    y.SetValue((-(double)a.getPesos().GetValue(0, 0) + (double)a.getPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)a.getPesos().GetValue(0, 2), i);
                }
                else if (type == "regresion_logistica")
                {
                    y.SetValue((-(double)rl.getPesos().GetValue(0, 0) + (double)rl.getPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)rl.getPesos().GetValue(0, 2), i);
                }
                */

            }

            //int b = 0;
            if (type == "perceptron")
            {
                color_pen = Color.Blue;
                //b = 0;
            }
            else if (type == "adaline")
            {
                color_pen = Color.Yellow;
                //b = 1;
            }
            else if (type == "regresion_logistica")
            {
                color_pen = Color.Red;
                //b = 2;
            }
            else
            {
                color_pen = Color.DarkGreen;
            }
            //Pen lapiz = plumas[b];
            
            Pen lapiz = new Pen(color_pen, 3);
            bitmap_temp.DrawLine(lapiz, CoordenadaAdaptadaToReal((double)x.GetValue(0)), CoordenadaAdaptadaToReal((double)y.GetValue(0)), CoordenadaAdaptadaToReal((double)x.GetValue(9)), CoordenadaAdaptadaToReal((double)y.GetValue(9)));

            //this.Invoke((MethodInvoker)(() => this.mainForm.ImagePlano = bm_temp));// this.Error_cmp.Series[series].Points.AddXY(x, y)));
            if (DibujarBitmap)
            {
                this.mainForm.ImagePlano = bm_temp;
            }

            //plano.Image = bm_temp;
            //plano.Refresh();

        }

        private int CoordenadaAdaptadaToReal(double coordenada)
        {
            return (int)((coordenada * 60) + 300);
        }

        private float[] CoordenadaRealToAdaptada(int posicion_original_x, int posicion_original_y)
        {
            float posicion_adaptada_x = ((float)posicion_original_x - 300) / 60;
            if (posicion_adaptada_x < 0)
            {
                posicion_adaptada_x *= -1;
            }

            float posicion_adaptada_y = ((float)posicion_original_y - 300) / 60;
            if (posicion_adaptada_y < 0)
            {
                posicion_adaptada_y *= -1;
            }

            if (posicion_original_x <= 300 && posicion_original_y <= 300)
            {
                posicion_adaptada_x *= -1;
            }
            else if (posicion_original_x <= 600 && posicion_original_y <= 300)
            {
                posicion_adaptada_y = (300 - (float)posicion_original_y) / 60;
            }
            else if (posicion_original_x <= 300 && posicion_original_y <= 600)
            {
                posicion_adaptada_x *= -1;
                posicion_adaptada_y *= -1;
            }
            else if (posicion_original_x <= 600 && posicion_original_y <= 600)
            {
                posicion_adaptada_y *= -1;
            }

            float[] xTemp = new float[2];
            xTemp[0] = posicion_adaptada_x;
            xTemp[1] = posicion_adaptada_y;
            return xTemp;
        }

        public void ActualizarGraficaError(string series, double x, double y)
        {
            this.mainForm.ErrorComponent(series, x, y);
        }

        public void Dibujar_Clases(Punto p)
        {
            Graphics bitmap_temp = Graphics.FromImage(bitmap_plano);
            Graphics bitmap_temp_respaldo = Graphics.FromImage(respaldo);

            //Pen pluma;

            Pen pluma = plumas[p.getTipo()]; //new Pen(Color.Green, 3);

            bitmap_temp.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
            bitmap_temp_respaldo.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
            //this.mainForm.ImagePlano = bitmap_plano;
            //plano.Image = bitmap_plano;
            //plano.Refresh();
        }

        public void Dibujar_bitmap_mlp(MLP.MLP mlp, List<Punto> lista_puntos_dibujar )
        {
            for (float x = -5; x < 5; x = x + 0.5f)
            {
                for (float y = 5; y > -5; y = y - 0.5f)
                {
                    Punto punto_dibujar = new Punto(x, y, 5, CoordenadaAdaptadaToReal(x), CoordenadaAdaptadaToReal(y));
                    punto_dibujar.setTipo(mlp.Forward(punto_dibujar, true, false));
                    lista_puntos_dibujar.Add(punto_dibujar);
                    //Dibujar_Clases(punto_dibujar);
                }
            }
            lista_puntos_dibujar.Reverse();
            DibujarPuntos(plumas, lista_puntos_dibujar);
        }

        public void GetClassReal(MLP.MLP mlp, List<Punto> lista_puntos)
        {
            foreach (Punto p in lista_puntos)
            {
                Console.WriteLine("Clase real: " + p.getTipo().ToString());
                mlp.Forward(p, true, false);
            }
        }
    }
}
