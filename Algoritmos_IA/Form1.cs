using Algoritmos_IA.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumSharp;

namespace Algoritmos_IA
{
    public partial class Form1 : Form
    {
        List<Punto> lista_puntos;
        Graphics plano_dibujar, respaldo;
        Perceptron p;
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
            labelCoordenadaXClick.Text = punto_generado.getPosicionAdaptadaX().ToString();
            labelCoordenadaYClick.Text = punto_generado.getPosicionAdaptadaY().ToString();
            dibujar_punto(punto_generado);

        }

        private void dibujar_punto(Punto p)
        {
            Pen pluma;
            if (p.getTipo() == 0)
            {
                pluma = new Pen(Color.Green, 1);
                respaldo.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
            }
            else
            {
                pluma = new Pen(Color.Red, 1);
                respaldo.DrawLine(pluma, p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, p.getPosicionOriginalX() + 4, p.getPosicionOriginalY() + 4);
                respaldo.DrawLine(pluma, p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() + 4, p.getPosicionOriginalX() + 4, p.getPosicionOriginalY() - 4);
            }
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

            for( int i = -x_centro; i <= x_centro; i += 60)
            {
                e.Graphics.DrawLine(lapiz, 4, i, -4, i );
                e.Graphics.DrawLine(lapiz, i , 4, i, -4 );
            }
            respaldo = plano.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private async void buttonPerceptron_Click(object sender, EventArgs e)
        {
            create_error_graphic();
            this.Error_cmp.Series["Perceptron"].Points.Clear();

           
            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    this.Invoke((MethodInvoker)(() => this.Error_cmp.Series["Perceptron"].Points.AddXY(i, i * 10) ));
                    
                }
            });

            this.p = new Perceptron(Int32.Parse(textBoxEpocasMaximas.Text), float.Parse(textBoxLR.Text), lista_puntos, 0);
            p.inicializar();
            dibujarLinea();
                        
            /*
             * var w = np.random.rand(1,3);
            Array x = (Array)w;
            x.SetValue(0,0,0);

            Array x2 = (Array)np.random.rand(3,1);

            var go = np.dot((NDArray)x, (NDArray)x2);
            var go2 = np.matmul((NDArray)x, (NDArray)x2);
            */
            Pen lapiz = new Pen(Color.Red, 1);
            while (!p.getEntrenado() && p.getEpocaActual() < p.getEpocas())
            {
                p.setEntrenado(true);
                for (int i = 0; i < p.getPuntos().Count; i++)
                {
                    float[,] xTemp = new float[3, 1];
                    xTemp[0, 0] = -1;
                    xTemp[1, 0] = p.getPuntos()[i].getPosicionAdaptadaX();
                    xTemp[2, 0] = p.getPuntos()[i].getPosicionAdaptadaY();

                    int error = p.getPuntos()[i].getTipo() - p.funcionEscalon(xTemp); ;
                    if (error != 0)
                    {
                        p.setEntrenado(false);
                        //var cos = np.multiply(error, np.transpose(xTemp));
                        //var cos2 = np.multiply(p.getLR(), np.multiply(error, np.transpose(xTemp)));
                        p.setPeso((Array)((NDArray)p.getPesos() + np.multiply(p.getLR(), np.multiply(error, np.transpose(xTemp) ))));
                        await Task.Factory.StartNew(() =>
                        {
                            plano_dibujar = respaldo;
                            Array x = (Array)np.zeros(10);
                            Array y = (Array)np.zeros(10);
            
                            for(int ii = 0, jj = -5; ii<10; ii++, jj++){
                                x.SetValue(jj,ii);
                                y.SetValue((-(double)p.getPesos().GetValue(0,0) -(double)p.getPesos().GetValue(0,1)*(double)x.GetValue(ii))/(double)p.getPesos().GetValue(0,2),i);
                            }
                            this.Invoke((MethodInvoker)(() => plano_dibujar.DrawLine(lapiz, coordenadaAdaptadaToReal((double)x.GetValue(0)), coordenadaAdaptadaToReal((double)y.GetValue(0)), coordenadaAdaptadaToReal((double)x.GetValue(9)), coordenadaAdaptadaToReal((double)y.GetValue(9)))));
                        });
                    }
                }
                p.setEpocaActual(p.getEpocaActual() + 1);
            }
            dibujarLinea();
        }

        private void dibujarLinea(){
            plano_dibujar = respaldo;
            Array x = (Array)np.zeros(10);
            Array y = (Array)np.zeros(10);
            
            for(int i = 0, j = -5; i<10; i++, j++){
                x.SetValue(j,i);
                y.SetValue((-(double)p.getPesos().GetValue(0,0) -(double)p.getPesos().GetValue(0,1)*(double)x.GetValue(i))/(double)p.getPesos().GetValue(0,2),i);
            }
            Pen lapiz = new Pen(Color.Red, 1);
            plano_dibujar.DrawLine(lapiz, coordenadaAdaptadaToReal((double)x.GetValue(0)), coordenadaAdaptadaToReal((double)y.GetValue(0)), coordenadaAdaptadaToReal((double)x.GetValue(9)), coordenadaAdaptadaToReal((double)y.GetValue(9)));
        }

        private int coordenadaAdaptadaToReal(double coordenada){
            //return (int)((coordenada+300) * 60); //((float)posicion_original_x - 300) / 60;
            return (int)((coordenada * 60) + 300);
        }

        private void create_error_graphic()
        {
            this.Error_cmp.Series["Perceptron"].Points.AddXY(1, 10);
            this.Error_cmp.Series["Perceptron"].Points.AddXY(2, 20);
            this.Error_cmp.Series["Perceptron"].Points.AddXY(3, 30);
            this.Error_cmp.Series["Perceptron"].Points.AddXY(4, 40);
            this.Error_cmp.Series["Perceptron"].Points.AddXY(5, 50);
            this.Error_cmp.Series["Perceptron"].Points.AddXY(6, 40);
            this.Error_cmp.Series["Perceptron"].Points.AddXY(7, 50);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
