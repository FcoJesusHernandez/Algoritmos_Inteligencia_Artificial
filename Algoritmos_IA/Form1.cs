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
        List<Punto> lista_puntos, lista_puntos_dibujar;
        Bitmap bitmap_plano, respaldo, bitmap_solo_plano;
        Perceptron p;
        Adaline a;
        RegresionLogistica rl;
        readonly List<Pen> plumas;
        List<int> neuronasXcapa;
        int CapaActual = 1;
        int Capas;
        public Form1()
        {
            InitializeComponent();

            Capas = Int32.Parse(CapasTb.Text);
            neuronasXcapa = new List<int>();
            lista_puntos = new List<Punto>();
            lista_puntos_dibujar = new List<Punto>();
            plumas = new List<Pen>();
            MlpBtn.Enabled = false;
            GuiaCapasLabel.Text = "Capa " + CapaActual.ToString() + "/" + CapasTb.Text;
            Plano_Paint();
            ClasesSelected();
            //LlenarPlumas();
        }
        public Image ImagePlano
        {
            get { return plano.Image; }
            set { this.Invoke((MethodInvoker)(() => plano.Image = value)); }
        }

        public void ErrorComponent(string series, double x, double y)
        {
            this.Invoke((MethodInvoker)(() => this.Error_cmp.Series[series].Points.AddXY(x, y)));
        }

        protected void ClasesTb_TextChanged(object sender, EventArgs e)
        {
            ClaseSelected.Items.Clear();
            plumas.Clear();
            if (ClasesTb.Text != "")
            {
                ClasesSelected();
            }
            else
            {


            }

        }

        private void ClasesSelected()
        {
            for (int i = 0; i < Int32.Parse(ClasesTb.Text); i++)
            {
                ClaseSelected.Items.Add(i.ToString());
            }
            ClaseSelected.SelectedIndex = 0;
            LlenarPlumas(Int32.Parse(ClasesTb.Text));
        }

        protected void CapasTb_TextChanged(object sender, EventArgs e)
        {
            if (CapasTb.Text != "")
            {
                neuronasXcapa.Clear();
                CapaActual = 1;
                Capas = Int32.Parse(CapasTb.Text);
                NextBtn.Enabled = true;
                GuiaCapasLabel.Text = "Capa " + CapaActual.ToString() + "/" + CapasTb.Text;
                GuiaCapasLabel.ForeColor = SystemColors.Control;
                NeuronaPcTb.Visible = true;
                NextBtn.Visible = true;
            }
            else
            {
                GuiaCapasLabel.Text = "Error de capas";
                GuiaCapasLabel.ForeColor = Color.OrangeRed;
                NeuronaPcTb.Visible = false;
                NextBtn.Visible = false;
            }
        }

        public void LlenarPlumas(int cantClases)
        {
            plumas.Clear();
            Random random = new Random();
            for (int i = 0; i < cantClases; i++)
            {
                Clases clase = new Clases(random);
                plumas.Add(clase.Get_Pluma());
            }
        }

        private async void Plano_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            int tipo;

            if (a != null && a.getCompletado())  /// nota: deberia ir a.getEntrenado(), pero causa errores cuando no se alcanza el error minimo
            {
                if (!p.GetEntrenado())
                {
                    labelAlerta.Text = "La clasificación puede ser incorrecta ya que no se alcanzó el error mínimo";
                }
                float[] coordenadasAdaptadas = CoordenadaRealToAdaptada(click.X, click.Y);
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
            else if (p != null && p.GetEntrenado())
            {
                float[] coordenadasAdaptadas = CoordenadaRealToAdaptada(click.X, click.Y);
                float[,] xTemp = new float[3, 1];
                xTemp[0, 0] = -1;
                xTemp[1, 0] = coordenadasAdaptadas[0];
                xTemp[2, 0] = coordenadasAdaptadas[1];

                tipo = p.FuncionEscalon(xTemp);
            }
            else
            {
                tipo = Int32.Parse(ClaseSelected.SelectedItem.ToString());
                /*
                if (click.Button.ToString() == "Right")
                {
                    tipo = 1;
                }
                else
                {
                    tipo = 0;
                }
                */
                //tipo = 0;
            }
            Punto punto_generado = new Punto(click.X, click.Y, tipo);
            lista_puntos.Add(punto_generado);
            await Task.Factory.StartNew(() =>
                this.Invoke((MethodInvoker)(() => labelCoordenadaXClick.Text = punto_generado.getPosicionAdaptadaX().ToString()))
            );

            await Task.Factory.StartNew(() =>
                this.Invoke((MethodInvoker)(() => labelCoordenadaYClick.Text = punto_generado.getPosicionAdaptadaY().ToString()))
            );

            //Dibujar_punto(punto_generado);
            Dibujar_Clases(punto_generado);
            if (lista_puntos.Count > 2)
            {
                InicializarBtn.Enabled = true;
            }
        }

        public void Dibujar_Clases(Punto p)
        {
            Graphics bitmap_temp = Graphics.FromImage(bitmap_plano);
            Graphics bitmap_temp_respaldo = Graphics.FromImage(respaldo);

            //Pen pluma;

            SolidBrush pluma = new SolidBrush(plumas[p.getTipo()].Color);

            Pen pluma_border = new Pen(Color.Black, 1);

            bitmap_temp.FillEllipse(pluma, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));
            bitmap_temp.DrawEllipse(pluma_border, new Rectangle(p.getPosicionOriginalX() - 4, p.getPosicionOriginalY() - 4, 8, 8));

            plano.Image = bitmap_plano;
            //plano.Image = bitmap_plano;
            plano.Refresh();
        }

        private void Dibujar_punto(Punto p)
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

        private void Plano_Paint()
        {
            Bitmap img = new Bitmap(plano.Width, plano.Height);
            Graphics imgBitmap = Graphics.FromImage(img);

            imgBitmap.Clear(Color.FromArgb(30, 30, 46));
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

        private void UC_ControlsTank_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.Write("You pressed:" + e.KeyChar.ToString());
        }

        private void InicializarBtn_Click(object sender, EventArgs e)
        {
            labelAlerta.Text = "";

            this.Error_cmp.Series["Perceptron"].Points.Clear();
            this.Error_cmp.Series["Adaline"].Points.Clear();
            this.Error_cmp.Series["Regresión logistica"].Points.Clear();

            if (PerceptronSwitch.Value == true)
            {
                this.p = new Perceptron(Int32.Parse(EpocasMaximasTb.Text), float.Parse(LearningRateTb.Text.ToString()), lista_puntos, 0);
                p.Inicializar();
                bitmap_plano = new Bitmap(respaldo);
                DibujarLinea(false, "perceptron");
            }
            else
            {

            }
            if (AdalineSwitch.Value == true)
            {
                this.a = new Adaline(Int32.Parse(EpocasMaximasTb.Text), float.Parse(LearningRateTb.Text), lista_puntos, 0);
                a.inicializar();
                bitmap_plano = new Bitmap(respaldo);
                DibujarLinea(false, "adaline");
            }
            else
            {

            }
            if (RegresionLogisticaSwitch.Value == true)
            {
                this.rl = new RegresionLogistica(Int32.Parse(EpocasMaximasTb.Text), float.Parse(LearningRateTb.Text), lista_puntos, 0);
                rl.inicializar();
                bitmap_plano = new Bitmap(respaldo);
                DibujarLinea(false, "regresion_logistica");
                //bunifuFlatButtonEntrenarRegresionLogistica.Enabled = true;
            }
            else
            {

            }

        }

        private void DibujarLinea(bool definitivo, string type) {
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

            for (int i = 0, j = -5; i < 10; i++, j++) {
                x.SetValue(j, i);
                if (type == "perceptron")
                {
                    y.SetValue((-(double)p.GetPesos().GetValue(0, 0) + (double)p.GetPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)p.GetPesos().GetValue(0, 2), i);
                }
                else if (type == "adaline")
                {
                    y.SetValue((-(double)a.getPesos().GetValue(0, 0) + (double)a.getPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)a.getPesos().GetValue(0, 2), i);
                }
                else if (type == "regresion_logistica") {
                    y.SetValue((-(double)rl.getPesos().GetValue(0, 0) + (double)rl.getPesos().GetValue(0, 1) * (double)x.GetValue(i)) / (double)rl.getPesos().GetValue(0, 2), i);
                }

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
            else if (type == "regresion_logistica") {
                color_pen = Color.Red;
                //b = 2;
            }
            else {
                color_pen = Color.DarkGreen;
            }
            //Pen lapiz = plumas[b];
            Pen lapiz = new Pen(color_pen, 3);
            bitmap_temp.DrawLine(lapiz, CoordenadaAdaptadaToReal((double)x.GetValue(0)), CoordenadaAdaptadaToReal((double)y.GetValue(0)), CoordenadaAdaptadaToReal((double)x.GetValue(9)), CoordenadaAdaptadaToReal((double)y.GetValue(9)));

            plano.Image = bm_temp;
            plano.Refresh();
        }

        private int CoordenadaAdaptadaToReal(double coordenada) {
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

        private void Create_error_graphic()
        {
            this.Error_cmp.Series["Perceptron"].Points.AddXY(1, 10);
        }

        private async Task Perceptron_function()
        {
            //buttonPerceptron.Enabled = false;
            //button1.Enabled = false;
            //Competir.Enabled = false;

            Pen lapiz = new Pen(Color.Red, 3);
            //Array x = (Array)np.zeros(10);
            //Array y = (Array)np.zeros(10);

            await Task.Factory.StartNew(() =>
            {
                while (!p.GetEntrenado() && p.GetEpocaActual() < p.GetEpocas())
                {
                    p.SetEntrenado(true);
                    p.SetErrorAcumulado(0);
                    for (int i = 0; i < p.GetPuntos().Count; i++)
                    {
                        float[,] xTemp = new float[3, 1];
                        xTemp[0, 0] = -1;
                        xTemp[1, 0] = p.GetPuntos()[i].getPosicionAdaptadaX();
                        xTemp[2, 0] = p.GetPuntos()[i].getPosicionAdaptadaY();

                        int error = p.GetPuntos()[i].getTipo() - p.FuncionEscalon(xTemp);


                        if (error != 0)
                        {
                            p.SetErrorAcumulado(p.GetErrorAcumulado() + 1);
                            p.SetEntrenado(false);
                            p.SetPeso((Array)((NDArray)p.GetPesos() + np.multiply(p.GetLR(), np.multiply(error, np.transpose(xTemp)))));

                            this.Invoke((MethodInvoker)(() => DibujarLinea(false, "perceptron")));
                        }
                    }
                    this.Invoke((MethodInvoker)(() => this.Error_cmp.Series["Perceptron"].Points.AddXY(p.GetEpocaActual(), p.GetErrorAcumulado())));
                    p.SetEpocaActual(p.GetEpocaActual() + 1);
                }
                //this.Invoke((MethodInvoker)(() => buttonPerceptron.Enabled = true));

            });

            DibujarLinea(true, "perceptron");
        }

        private async Task Adaline_function()
        {
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
                    if (a.getErrorActualEpoca() > float.Parse(ErrorTb.Text))
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

                            a.setErrorAcumulado(a.getErrorAcumulado() + Math.Pow(error, 2));

                            a.setEntrenado(false);

                            a.setPeso((Array)((NDArray)a.getPesos() + np.multiply(a.getLR(), np.multiply(error, np.multiply(sigmoide * (1 - sigmoide), np.transpose(xTemp))))));

                            a.setErrorAcumulado(a.getErrorAcumulado() + error);

                            this.Invoke((MethodInvoker)(() => DibujarLinea(false, "adaline")));
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
                if (a.getEpocaActual() < a.getEpocas())
                {
                    a.setEntrenado(true);
                }
                a.setCompletado(true);
                //this.Invoke((MethodInvoker)(() => buttonPerceptron.Enabled = true));
            });

            DibujarLinea(true, "adaline");
        }

        private async Task RegresionLogistica_function()
        {
            Pen lapiz = new Pen(Color.BlueViolet, 3);
            Array x = (Array)np.zeros(10);
            Array y = (Array)np.zeros(10);

            await Task.Factory.StartNew(() =>
            {
                rl.setCompletado(false);
                while (!rl.getEntrenado() && rl.getEpocaActual() < rl.getEpocas())
                {
                    rl.setEntrenado(true);

                    // Si error medio^2 es mayor a 0 y mayor a error maximo entra
                    if (rl.getEpocaActual() == 0)
                    {
                        rl.setErrorActualEpoca(1);
                    }
                    else
                    {
                        rl.setErrorActualEpoca(Math.Pow(rl.getErrorAcumulado() / rl.getPuntos().Count, 2));
                    }

                    if (rl.getErrorActualEpoca() > float.Parse(ErrorTb.Text))
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

                            rl.setErrorAcumulado(rl.getErrorAcumulado() + error);

                            rl.setEntrenado(false);

                            rl.setPeso((Array)((NDArray)rl.getPesos() + np.multiply(rl.getLR(), np.multiply(error, np.transpose(xTemp)))));

                            rl.setErrorAcumulado(rl.getErrorAcumulado() + error);

                            this.Invoke((MethodInvoker)(() => DibujarLinea(false, "regresion_logistica")));
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
                if (rl.getEpocaActual() < rl.getEpocas())
                {
                    rl.setEntrenado(true);
                }
                rl.setCompletado(true);
                //this.Invoke((MethodInvoker)(() => buttonPerceptron.Enabled = true));
            });

            DibujarLinea(true, "regresion_logistica");
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (CapaActual == Int32.Parse(CapasTb.Text))
            {
                neuronasXcapa.Add(Int32.Parse(ClasesTb.Text));
                NeuronaPcTb.Text = "0";
                NextBtn.Enabled = false;
                MlpBtn.Enabled = true;
                //var capas = 2;
            }
            else
            {
                neuronasXcapa.Add(Int32.Parse(NeuronaPcTb.Text));// NeuronaPcTb);
                if (CapaActual + 1 == Int32.Parse(CapasTb.Text))
                {
                    NeuronaPcTb.Text = ClasesTb.Text;
                }
                else
                {
                    NeuronaPcTb.Text = "1";
                }
            }
            CapaActual++;
            if (CapaActual <= Int32.Parse(CapasTb.Text))
            {
                GuiaCapasLabel.Text = "Capa " + CapaActual.ToString() + "/" + CapasTb.Text;
            }
            else
            {
                GuiaCapasLabel.Text = "Configuración completa";
                GuiaCapasLabel.ForeColor = Color.Green;
                NeuronaPcTb.Visible = false;
                NextBtn.Visible = false;
            }
        }

        private async void MlpBtn_Click(object sender, EventArgs e)
        {
            
            MLP mlp = new MLP(Int32.Parse(EpocasMaximasTb.Text), Capas, neuronasXcapa, float.Parse(LearningRateTb.Text), lista_puntos, double.Parse(ErrorTb.Text));
            await mlp.Forward_Backward(bitmap_plano, respaldo, bitmap_solo_plano, this , plumas, lista_puntos, LineasSwitch.Value);

            //getClassReal(mlp);
            /*

            //Datos de prueba, hay que quitarlos
            Punto prueba = new Punto(2, 2, 5, CoordenadaAdaptadaToReal(2), CoordenadaAdaptadaToReal(2));
            mlp.Forward(prueba, true, false);
            Punto prueba2 = new Punto(2, -2, 5, CoordenadaAdaptadaToReal(2), CoordenadaAdaptadaToReal(-2));
            mlp.Forward(prueba2, true, false);
            Punto prueba3 = new Punto(-2, -2, 5, CoordenadaAdaptadaToReal(-2), CoordenadaAdaptadaToReal(-2));
            mlp.Forward(prueba3, true, false);
            Punto prueba4 = new Punto(-2, 2, 5, CoordenadaAdaptadaToReal(-2), CoordenadaAdaptadaToReal(2));
            mlp.Forward(prueba4, true, false);
            Punto prueba5 = new Punto(-3, 2, 5);
            mlp.Forward(prueba5, true, false);
            */
            //dibujar_bitmap_mlp(mlp);
            //ImgControl.DibujarPuntos(plumas, lista_puntos_dibujar

            //dibujar_bitmap_mlp(mlp);
        }

        private void ClaseSelected_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void CompetirBtn_Click(object sender, EventArgs e)
        {
            var ListTask = new List<Task>();

            if (PerceptronSwitch.Value == true)
            {
                ListTask.Add(Perceptron_function());
            }
            if (AdalineSwitch.Value == true)
            {
                ListTask.Add(Adaline_function());
            }
            if (RegresionLogisticaSwitch.Value == true)
            {
                ListTask.Add(RegresionLogistica_function());
            }
            if (ListTask.Count > 0)
            {
                await Task.WhenAny(ListTask.ToArray());
            }
            else
            {
                Console.WriteLine("No existen tareas para ejecutar");
            }
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            if ((p != null && p.GetCompletado()) || (a != null && a.getCompletado()) || (rl != null && rl.getCompletado()) || (rl==null || p == null || a == null))
            {
                labelAlerta.Text = "";
                this.Error_cmp.Series["Perceptron"].Points.Clear();
                this.Error_cmp.Series["Adaline"].Points.Clear();
                this.Error_cmp.Series["Regresión logistica"].Points.Clear();

                p = null;
                a = null;
                rl = null;

                lista_puntos = new List<Punto>();
                bitmap_plano = new Bitmap(bitmap_solo_plano);
                respaldo = new Bitmap(bitmap_solo_plano);
                plano.Image = bitmap_solo_plano;
                plano.Refresh();
            }
        }

    }
}
