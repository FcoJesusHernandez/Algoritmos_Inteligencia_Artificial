using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_IA
{
    public partial class Form1 : Form
    {
        List<Punto> lista_puntos;
        Graphics plano_dibujar;
        public Form1()
        {
            InitializeComponent();
            lista_puntos = new List<Punto>();
        }

        private void plano_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            
            int tipo;
            if( click.Button.ToString()=="Right" )
            {
                tipo = 1;
            }
            else
            {
                tipo = 0;
            }

            Punto punto_generado = new Punto(click.X,click.Y,tipo);
            lista_puntos.Add(punto_generado);
            label1.Text = punto_generado.getPosicionOriginalX().ToString() + " ( " + punto_generado.getPosicionAdaptadaX().ToString() + " ) ";
            label2.Text = punto_generado.getPosicionOriginalY().ToString() + " ( " + punto_generado.getPosicionAdaptadaY().ToString() + " ) ";
            dibujar_punto(punto_generado);

        }

        private void dibujar_punto(Punto p)
        {
            Pen pluma;
            if (p.getTipo()==0)
            {
                pluma = new Pen(Color.Green, 1);
            }
            else
            {
                pluma = new Pen(Color.Red, 1);
            }
            plano_dibujar.DrawRectangle(pluma, new Rectangle(p.getPosicionOriginalX(), p.getPosicionOriginalY(), 5, 5));
        }

        private void plano_Paint(object sender, PaintEventArgs e)
        {
            int x_centro = plano.Width / 2;
            int y_centro = plano.Height / 2;

            Pen lapiz = new Pen(Color.Black, 1);

            e.Graphics.TranslateTransform(x_centro, y_centro);
            e.Graphics.ScaleTransform(1, -1);

            e.Graphics.DrawLine(lapiz, x_centro * -1, 0, x_centro * 2, 0);
            e.Graphics.DrawLine(lapiz, 0 , y_centro, 0 , y_centro * -1);

            //e.Graphics.PageScale = .2f;  // investigar como funciona

            for( int i = -x_centro; i <= x_centro; i += 30)
            {
                e.Graphics.DrawLine(lapiz, 4, i, -4, i );
                e.Graphics.DrawLine(lapiz, i , 4, i, -4 );
            }
            plano_dibujar = plano.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
