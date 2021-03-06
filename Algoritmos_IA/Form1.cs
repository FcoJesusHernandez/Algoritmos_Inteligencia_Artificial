﻿using Algoritmos_IA.Class;
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
        //Graphics plano_dibujar;
        Bitmap bitmap_plano, respaldo, bitmap_solo_plano;
        Perceptron p;
        Adaline a;

        public Form1()
        {
            InitializeComponent();
            plano_Paint();
            lista_puntos = new List<Punto>();

            buttonPerceptron.Enabled = false;
            buttonInicializacion.Enabled = false;
            buttonLimpiar.Enabled = false;
            buttonCompetir.Enabled = false;
            buttonAdaline.Enabled = false;
        }

        private async void plano_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            int tipo;

            if (a != null && a.getCompletado())  /// nota: deberia ir a.getEntrenado(), pero causa errores cuando no se alcanza el error minimo
            {
                if (!p.getEntrenado())
                {
                    labelAlerta.Text = "La clasificación puede ser incorrecta ya que no se alcanzó el error mínimo";
                }
                float[] coordenadasAdaptadas = coordenadaRealToAdaptada(click.X, click.Y);
                float[,] xTemp = new float[3, 1];
                xTemp[0, 0] = -1;
                xTemp[1, 0] = coordenadasAdaptadas[0];
                xTemp[2, 0] = coordenadasAdaptadas[1];

                double sigmoide = a.funcion_sigmoide(xTemp);
                if (sigmoide > .5)
                {
                    tipo = 1;
                }
                else
                {
                    tipo = 0;
                }
            }
            else if (p != null && p.getEntrenado())
            {
                float[] coordenadasAdaptadas = coordenadaRealToAdaptada(click.X, click.Y);
                float[,] xTemp = new float[3, 1];
                xTemp[0, 0] = -1;
                xTemp[1, 0] = coordenadasAdaptadas[0];
                xTemp[2, 0] = coordenadasAdaptadas[1];

                tipo = p.funcionEscalon(xTemp);
            }
            else
            {
                if (click.Button.ToString() == "Right")
                {
                    tipo = 1;
                }
                else
                {
                    tipo = 0;
                }
            }
            Punto punto_generado = new Punto(click.X, click.Y, tipo);
            lista_puntos.Add(punto_generado);
            await Task.Factory.StartNew(() =>
                this.Invoke((MethodInvoker)(() => labelCoordenadaXClick.Text = punto_generado.getPosicionAdaptadaX().ToString()))
            );

            await Task.Factory.StartNew(() =>
                this.Invoke((MethodInvoker)(() => labelCoordenadaYClick.Text = punto_generado.getPosicionAdaptadaY().ToString()))
            );

            dibujar_punto(punto_generado);
            if (lista_puntos.Count>2)
            {
                buttonInicializacion.Enabled = true;
            }
        }

        private void dibujar_punto(Punto p)
        {
            Graphics bitmap_temp = Graphics.FromImage(bitmap_plano);
            Graphics bitmap_temp_respaldo = Graphics.FromImage(respaldo);

            Pen pluma;
            if (p.getTipo() == 0)
            {
                pluma = new Pen(Color.Green, 3);
                bitmap_temp.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
                bitmap_temp_respaldo.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
            }
            else
            {
                pluma = new Pen(Color.Red, 3);
                bitmap_temp.DrawLine(pluma, p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, p.getPosicionOriginalX() + 4, p.getPosicionOriginalY() + 4);
                bitmap_temp.DrawLine(pluma, p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() + 4, p.getPosicionOriginalX() + 4, p.getPosicionOriginalY() - 4);

                bitmap_temp_respaldo.DrawLine(pluma, p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, p.getPosicionOriginalX() + 4, p.getPosicionOriginalY() + 4);
                bitmap_temp_respaldo.DrawLine(pluma, p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() + 4, p.getPosicionOriginalX() + 4, p.getPosicionOriginalY() - 4);
            }

            plano.Image = bitmap_plano;
            plano.Refresh();
        }

        private void plano_Paint()
        {
            Bitmap img = new Bitmap(plano.Width, plano.Height);
            Graphics imgBitmap = Graphics.FromImage(img);

            int x_centro = plano.Width / 2;
            int y_centro = plano.Height / 2;

            Pen lapiz = new Pen(Color.Black, 1);

            imgBitmap.TranslateTransform(x_centro, y_centro);
            imgBitmap.ScaleTransform(1, -1);

            imgBitmap.DrawLine(lapiz, x_centro * -1, 0, x_centro * 2, 0);
            imgBitmap.DrawLine(lapiz, 0, y_centro, 0, y_centro * -1);

            //e.Graphics.PageScale = .2f;  // investigar como funciona

            for (int i = -x_centro; i <= x_centro; i += 60)
            {
                imgBitmap.DrawLine(lapiz, 4, i, -4, i);
                imgBitmap.DrawLine(lapiz, i, 4, i, -4);
            }

            plano.Image = img;
            respaldo = new Bitmap(img);
            bitmap_plano = img;
            bitmap_solo_plano = new Bitmap(img);
        }

        private void buttonInicializacion_Click(object sender, EventArgs e)
        {
            labelAlerta.Text = "";
            buttonLimpiar.Enabled = true;
            buttonPerceptron.Enabled = true;
            buttonInicializacion.Enabled = true;
            buttonAdaline.Enabled = true;
            buttonCompetir.Enabled = true;
            create_error_graphic();
            this.Error_cmp.Series["Perceptron"].Points.Clear();
            this.Error_cmp.Series["Adaline"].Points.Clear();

            this.p = new Perceptron(Int32.Parse(textBoxEpocasMaximas.Text), float.Parse(textBoxLR.Text), lista_puntos, 0);
            p.inicializar();
            bitmap_plano = new Bitmap(respaldo);
            dibujarLinea(false, "perceptron");

            
            //this.Error_cmp.Series["Adaline"].Points.Clear();

            this.a = new Adaline(Int32.Parse(textBoxEpocasMaximas.Text), float.Parse(textBoxLR.Text), lista_puntos, 0);
            a.inicializar();
            bitmap_plano = new Bitmap(respaldo);
            dibujarLinea(false, "adaline");
        }

        private async void buttonPerceptron_Click(object sender, EventArgs e)
        {
            await perceptron_function();
        }

        private void dibujarLinea(bool definitivo, string type){
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
            
            for(int i = 0, j = -5; i<10; i++, j++){
                x.SetValue(j,i);
                if(type == "perceptron")
                {
                    y.SetValue((-(double)p.getPesos().GetValue(0, 0) + (double)p.getPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)p.getPesos().GetValue(0, 2), i);
                }
                else
                {
                    y.SetValue((-(double)a.getPesos().GetValue(0, 0) + (double)a.getPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)a.getPesos().GetValue(0, 2), i);
                }
                
            }
            if (type == "perceptron")
            {
                color_pen = Color.Blue;
            }
            else
            {
                color_pen = Color.Yellow;
            }
            Pen lapiz = new Pen(color_pen, 3);
            bitmap_temp.DrawLine(lapiz, coordenadaAdaptadaToReal((double)x.GetValue(0)), coordenadaAdaptadaToReal((double)y.GetValue(0)), coordenadaAdaptadaToReal((double)x.GetValue(9)), coordenadaAdaptadaToReal((double)y.GetValue(9)));

            plano.Image = bm_temp;
            plano.Refresh();
        }

        private int coordenadaAdaptadaToReal(double coordenada){
            return (int)((coordenada * 60) + 300);
        }

        private float[] coordenadaRealToAdaptada(int posicion_original_x, int posicion_original_y)
        {
            float posicion_adaptada_x = ((float)posicion_original_x - 300) / 60;
            if (posicion_adaptada_x < 0)
            {
                posicion_adaptada_x = posicion_adaptada_x * -1;
            }

            float posicion_adaptada_y = ((float)posicion_original_y - 300) / 60;
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

            float[] xTemp = new float[2];
            xTemp[0] = posicion_adaptada_x;
            xTemp[1] = posicion_adaptada_y;
            return xTemp; 
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

        private async Task perceptron_function()
        {
            buttonInicializacion.Enabled = false;
            buttonPerceptron.Enabled = false;
            buttonCompetir.Enabled = false;

            Pen lapiz = new Pen(Color.Red, 3);
            //Array x = (Array)np.zeros(10);
            //Array y = (Array)np.zeros(10);

            await Task.Factory.StartNew(() =>
            {
                while (!p.getEntrenado() && p.getEpocaActual() < p.getEpocas())
                {
                    p.setEntrenado(true);
                    p.setErrorAcumulado(0);
                    for (int i = 0; i < p.getPuntos().Count; i++)
                    {
                        float[,] xTemp = new float[3, 1];
                        xTemp[0, 0] = -1;
                        xTemp[1, 0] = p.getPuntos()[i].getPosicionAdaptadaX();
                        xTemp[2, 0] = p.getPuntos()[i].getPosicionAdaptadaY();

                        int error = p.getPuntos()[i].getTipo() - p.funcionEscalon(xTemp);


                        if (error != 0)
                        {
                            p.setErrorAcumulado(p.getErrorAcumulado() + 1);
                            p.setEntrenado(false);
                            p.setPeso((Array)((NDArray)p.getPesos() + np.multiply(p.getLR(), np.multiply(error, np.transpose(xTemp)))));

                            this.Invoke((MethodInvoker)(() => dibujarLinea(false, "perceptron")));
                        }
                    }
                    this.Invoke((MethodInvoker)(() => this.Error_cmp.Series["Perceptron"].Points.AddXY(p.getEpocaActual(), p.getErrorAcumulado())));
                    p.setEpocaActual(p.getEpocaActual() + 1);
                }
                this.Invoke((MethodInvoker)(() => buttonInicializacion.Enabled = true));

            });

            dibujarLinea(true, "perceptron");
        }

        private async Task adaline_function()
        {
            buttonAdaline.Enabled = false;
            buttonCompetir.Enabled = false;
            //button1.Enabled = false;
            Pen lapiz = new Pen(Color.BlueViolet, 3);
            Array x = (Array)np.zeros(10);
            Array y = (Array)np.zeros(10);

            await Task.Factory.StartNew(() =>
            {
                a.setCompletado(false);
                while (!a.getEntrenado() && a.getEpocaActual() < a.getEpocas())
                {
                    a.setEntrenado(true);
                    //Console.WriteLine("Entra ciclo infinito");

                    // Si error medio^2 es mayor a 0 y mayor a error maximo entra
                    if (a.getEpocaActual() == 0)
                    {
                        a.setErrorActualEpoca(1);
                    }
                    else
                    {
                        a.setErrorActualEpoca(Math.Pow(a.getErrorAcumulado() / a.getPuntos().Count, 2));
                    }


                    Console.WriteLine(a.getErrorActualEpoca());
                    if (a.getErrorActualEpoca() > float.Parse(ErrorCmp.Text))
                    {
                        a.setEntrenado(true);
                        a.setErrorAcumulado(0);

                        for (int i = 0; i < a.getPuntos().Count; i++)
                        {

                            float[,] xTemp = new float[3, 1];
                            xTemp[0, 0] = -1;
                            xTemp[1, 0] = a.getPuntos()[i].getPosicionAdaptadaX();
                            xTemp[2, 0] = a.getPuntos()[i].getPosicionAdaptadaY();

                            double sigmoide = a.funcion_sigmoide(xTemp);
                            double error = a.getPuntos()[i].getTipo() - sigmoide;
                            //Console.WriteLine(error);

                            a.setErrorAcumulado(a.getErrorAcumulado() + error);

                            a.setEntrenado(false);

                            a.setPeso((Array)((NDArray)a.getPesos() + np.multiply(a.getLR(), np.multiply(error, np.multiply(sigmoide * (1 - sigmoide), np.transpose(xTemp))))));

                            a.setErrorAcumulado(a.getErrorAcumulado() + error);

                            this.Invoke((MethodInvoker)(() => dibujarLinea(false, "adaline")));
                        }

                        this.Invoke((MethodInvoker)(() => this.Error_cmp.Series["Adaline"].Points.AddXY(a.getEpocaActual(), a.getErrorActualEpoca())));

                        a.setEpocaActual(a.getEpocaActual() + 1);
                    }
                    else
                    {
                        a.setEpocaActual(a.getEpocas());
                        a.setEntrenado(true);
                    }

                }
                if(a.getEpocaActual() < a.getEpocas())
                {
                    a.setEntrenado(true);
                }
                a.setCompletado(true);
                this.Invoke((MethodInvoker)(() => buttonInicializacion.Enabled = true));


            });

            dibujarLinea(true, "adaline");
        }

        private async void buttonAdaline_Click(object sender, EventArgs e)
        {
            await adaline_function();
        }

        private async void buttonCompetir_Click(object sender, EventArgs e)
        {
            buttonCompetir.Enabled = false;
            buttonInicializacion.Enabled = false;
            buttonAdaline.Enabled = false;

            var tarea1 = perceptron_function();
            var tarea2 = adaline_function();
            await Task.WhenAll(tarea1, tarea2);

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            if ((p != null && p.getCompletado()) || (a!=null && a.getCompletado()))
            {
                labelAlerta.Text = "";
                this.Error_cmp.Series["Perceptron"].Points.Clear();
                this.Error_cmp.Series["Adaline"].Points.Clear();
                buttonLimpiar.Enabled = false;
                p = null;
                a = null;
                buttonPerceptron.Enabled = false;
                buttonInicializacion.Enabled = false;
                buttonCompetir.Enabled = false;
                buttonAdaline.Enabled = false;

                lista_puntos = new List<Punto>();
                bitmap_plano = new Bitmap(bitmap_solo_plano);
                respaldo = new Bitmap(bitmap_solo_plano);
                plano.Image = bitmap_solo_plano;
                plano.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
