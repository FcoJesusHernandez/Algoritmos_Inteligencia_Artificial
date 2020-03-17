using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_IA.Class
{
    class Img_control : Form
    {
        private Form1 mainForm = null;
        Bitmap bitmap_plano, respaldo, bitmap_solo_plano;
        public Img_control(Bitmap newBitmap, Bitmap newBitmap2, Bitmap newBitmap3, Form CallingForm)
        {
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
                bitmap_temp_respaldo.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));

                //plano.Image = bitmap_plano;
                this.mainForm.ImagePlano = bitmap_plano;
                //plano.Refresh();
            }
        }

        public void ActualizarGraficaError(string series, double x, double y)
        {
            this.mainForm.ErrorComponent(series, x, y);
        }
    }
}
