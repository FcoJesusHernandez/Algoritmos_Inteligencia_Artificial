using Algoritmos_IA.Class;
using Algoritmos_IA.Class.MLP;
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
        Bitmap bitmap_plano, respaldo, bitmap_solo_plano;
        Perceptron p;
        Adaline a;
        RegresionLogistica rl;
        List<Pen> plumas;
        //List<Pen> lista_plumas = new List<Pen>();

        public Form1()
        {
            InitializeComponent();
            plano_Paint();

            lista_puntos = new List<Punto>();
            plumas = new List<Pen>();
            //llenarPlumas();
            button1.Enabled = false;
            buttonPerceptron.Enabled = false;
            buttonLimpiar.Enabled = false;
            Competir.Enabled = false;
            buttonAdaline.Enabled = false;
            bunifuFlatButtonEntrenarRegresionLogistica.Enabled = false;
            llenarPlumas();            
        }


        public void llenarPlumas()
        {
            // n = numero de clases 
            //clase.get_Pluma().ToString();
            Random random = new Random();
            for (int i=0; i < 10; i++)
            {
                Clases clase = new Clases(random);
                plumas.Add(clase.get_Pluma());
                
            }
            

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
                buttonPerceptron.Enabled = true;
            }
        }

        private void dibujar_punto(Punto p)
        {
            /*if (numeroClases != 2)
            {
                dibujar_puntos(p);
            }*/
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

        /*
        private void dibujar_puntos(Punto p)
        {

             

            bitmap_temp.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
            bitmap_temp_respaldo.DrawEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
        }
        */

        private void plano_Paint()
        {
            Bitmap img = new Bitmap(plano.Width, plano.Height);
            Graphics imgBitmap = Graphics.FromImage(img);

            imgBitmap.Clear(Color.FromArgb(30,30,46));
            int x_centro = plano.Width / 2;
            int y_centro = plano.Height / 2;

            Pen lapiz = new Pen(Color.White, 1);

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

        private void buttonPerceptron_Click(object sender, EventArgs e)
        {
            labelAlerta.Text = "";
            buttonLimpiar.Enabled = true;
            button1.Enabled = true;
            buttonPerceptron.Enabled = true;
            buttonAdaline.Enabled = true;
            Competir.Enabled = true;


            //Borrar esto
            List<int> hola = new List<int>();

            hola.Add(2);
            hola.Add(2);

            MLP caca = new MLP(Int32.Parse(textBoxEpocasMaximas.Text), 2, hola, float.Parse(textBoxLR.Text), lista_puntos);
            caca.Forward_Backward();
            //fin de borrar esto
            Punto prueba = new Punto(2, 2, 6);
            caca.Forward(prueba, true);
            Punto prueba2 = new Punto(2, -2, 5);
            caca.Forward(prueba2, true);
            Punto prueba3 = new Punto(-2, -2, 5);
            caca.Forward(prueba3, true);
            Punto prueba4 = new Punto(-2, 2, 5);
            caca.Forward(prueba4, true);


            create_error_graphic();
            this.Error_cmp.Series["Perceptron"].Points.Clear();
            this.Error_cmp.Series["Adaline"].Points.Clear();
            this.Error_cmp.Series["Regresión logistica"].Points.Clear();

            this.p = new Perceptron(Int32.Parse(textBoxEpocasMaximas.Text), float.Parse(textBoxLR.Text.ToString()), lista_puntos, 0);
            p.inicializar();
            bitmap_plano = new Bitmap(respaldo);
            dibujarLinea(false, "perceptron");

            this.a = new Adaline(Int32.Parse(textBoxEpocasMaximas.Text), float.Parse(textBoxLR.Text), lista_puntos, 0);
            a.inicializar();
            bitmap_plano = new Bitmap(respaldo);
            dibujarLinea(false, "adaline");
            
            if (bunifuiOSSwitch1.Value == true)
            {
                this.rl = new RegresionLogistica(Int32.Parse(textBoxEpocasMaximas.Text), float.Parse(textBoxLR.Text), lista_puntos, 0);
                rl.inicializar();
                bitmap_plano = new Bitmap(respaldo);
                dibujarLinea(false, "regresion_logistica");
                bunifuFlatButtonEntrenarRegresionLogistica.Enabled = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
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
                else if(type == "adaline")
                {
                    y.SetValue((-(double)a.getPesos().GetValue(0, 0) + (double)a.getPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)a.getPesos().GetValue(0, 2), i);
                }
                else if(type == "regresion_logistica"){
                    y.SetValue((-(double)rl.getPesos().GetValue(0, 0) + (double)rl.getPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)rl.getPesos().GetValue(0, 2), i);
                }
                
            }

            int b = 0;
            if (type == "perceptron")
            {
                color_pen = Color.Blue;
                b = 0;
            }
            else if(type == "adaline")
            {
                color_pen = Color.Yellow;
                b = 1;
            }
            else if(type == "regresion_logistica"){
                color_pen = Color.Red;
                b = 2;
            }
            else{
                color_pen = Color.DarkGreen;
            }
            Pen lapiz = plumas[b];
            //Pen lapiz = new Pen(color_pen, 3);
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
            buttonPerceptron.Enabled = false;
            button1.Enabled = false;
            Competir.Enabled = false;

            


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
                this.Invoke((MethodInvoker)(() => buttonPerceptron.Enabled = true));

            });

            dibujarLinea(true, "perceptron");
        }

        private async Task adaline_function()
        {
            buttonAdaline.Enabled = false;
            Competir.Enabled = false;



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
                        a.setErrorActualEpoca(0.1);
                    }
                    else
                    {
                        a.setErrorActualEpoca(a.getErrorAcumulado() / a.getPuntos().Count);
                    }

                    //Console.WriteLine(a.getErrorActualEpoca());
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

                            a.setErrorAcumulado(a.getErrorAcumulado() + Math.Pow(error,2));

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
                this.Invoke((MethodInvoker)(() => buttonPerceptron.Enabled = true));


            });

            dibujarLinea(true, "adaline");
        }

        private async Task RegresionLogistica_function()
        {
            Competir.Enabled = false;
            bunifuFlatButtonEntrenarRegresionLogistica.Enabled = false;
            
            Pen lapiz = new Pen(Color.BlueViolet, 3);
            Array x = (Array)np.zeros(10);
            Array y = (Array)np.zeros(10);

            await Task.Factory.StartNew(() =>
            {
                rl.setCompletado(false);
                while (!rl.getEntrenado() && rl.getEpocaActual() < rl.getEpocas())
                {
                    rl.setEntrenado(true);
                    //Console.WriteLine("Entra ciclo infinito");

                    // Si error medio^2 es mayor a 0 y mayor a error maximo entra
                    if (rl.getEpocaActual() == 0)
                    {
                        rl.setErrorActualEpoca(1);
                    }
                    else
                    {
                        rl.setErrorActualEpoca(Math.Pow(rl.getErrorAcumulado() / rl.getPuntos().Count, 2));
                    }

                    //Console.WriteLine(a.getErrorActualEpoca());
                    if (rl.getErrorActualEpoca() > float.Parse(ErrorCmp.Text))
                    {
                        rl.setEntrenado(true);
                        rl.setErrorAcumulado(0);

                        for (int i = 0; i < rl.getPuntos().Count; i++)
                        {

                            float[,] xTemp = new float[3, 1];
                            xTemp[0, 0] = -1;
                            xTemp[1, 0] = rl.getPuntos()[i].getPosicionAdaptadaX();
                            xTemp[2, 0] = rl.getPuntos()[i].getPosicionAdaptadaY();

                            double sigmoide = rl.funcion_sigmoide(xTemp);
                            double error = rl.getPuntos()[i].getTipo() - sigmoide;
                            //Console.WriteLine(error);

                            rl.setErrorAcumulado(rl.getErrorAcumulado() + error);

                            rl.setEntrenado(false);

                            rl.setPeso((Array)((NDArray)rl.getPesos() + np.multiply(rl.getLR(), np.multiply(error, np.transpose(xTemp)))));

                            rl.setErrorAcumulado(rl.getErrorAcumulado() + error);

                            this.Invoke((MethodInvoker)(() => dibujarLinea(false, "regresion_logistica")));
                        }

                        this.Invoke((MethodInvoker)(() => this.Error_cmp.Series["Regresión logistica"].Points.AddXY(rl.getEpocaActual(), rl.getErrorActualEpoca())));

                        rl.setEpocaActual(rl.getEpocaActual() + 1);
                    }
                    else
                    {
                        rl.setEpocaActual(rl.getEpocas());
                        rl.setEntrenado(true);
                    }

                }
                if(rl.getEpocaActual() < rl.getEpocas())
                {
                    rl.setEntrenado(true);
                }
                rl.setCompletado(true);
                this.Invoke((MethodInvoker)(() => buttonPerceptron.Enabled = true));


            });

            dibujarLinea(true, "regresion_logistica");
        }

        private async void Adaline_Click(object sender, EventArgs e)
        {
            await adaline_function();
        }
        public void esto_Arreglara_todo()
        {

        }

        private async void Competir_Click(object sender, EventArgs e)
        {

            Competir.Enabled = false;
            buttonPerceptron.Enabled = false;
            buttonAdaline.Enabled = false;
            bunifuFlatButtonEntrenarRegresionLogistica.Enabled = false;

            var tarea1 = perceptron_function();
            var tarea2 = adaline_function();
            if (bunifuiOSSwitch1.Value==true)
            {
                var tarea3 = RegresionLogistica_function();
                await Task.WhenAny(tarea1, tarea2, tarea3);
            }
            else
            {
                await Task.WhenAny(tarea1, tarea2);
            }
        }

        private async void bunifuFlatButtonEntrenarRegresionLogistica_Click(object sender, EventArgs e)
        {
            await RegresionLogistica_function();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            if ((p != null && p.getCompletado()) || (a!=null && a.getCompletado()) || (rl != null && rl.getCompletado()))
            {
                labelAlerta.Text = "";
                this.Error_cmp.Series["Perceptron"].Points.Clear();
                this.Error_cmp.Series["Adaline"].Points.Clear();
                this.Error_cmp.Series["Regresión logistica"].Points.Clear();

                buttonLimpiar.Enabled = false;
                p = null;
                a = null;
                rl = null;
                button1.Enabled = false;
                buttonPerceptron.Enabled = false;
                Competir.Enabled = false;
                buttonAdaline.Enabled = false;
                bunifuFlatButtonEntrenarRegresionLogistica.Enabled = false;

                lista_puntos = new List<Punto>();
                bitmap_plano = new Bitmap(bitmap_solo_plano);
                respaldo = new Bitmap(bitmap_solo_plano);
                plano.Image = bitmap_solo_plano;
                plano.Refresh();
            }
        }

    }
}
