using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Neuro;
using Accord.Neuro.Learning;
using System.Windows.Forms;
using System.Drawing;

namespace Algoritmos_IA.Class.LV
{
    public class LM
    {
        Img_control ImgControl;
        double[][] input;
        int[] labels;
        int numeroEntradas=2;
        int numeroSalidas;
        int[] capas;
        ActivationNetwork red;
        double[][] outputs;
        int epocasMaximas;
        float lr;
        double errorDeseado;
        List<Punto> lista_puntos;
        public LM(int epocas, List<int> neuronaXCapa, float lr, List<Punto> puntos, double errorDeseado) 
        {
            epocasMaximas = epocas;
            this.lr = lr;
            this.errorDeseado = errorDeseado;
            this.lista_puntos = puntos;
            convierte(neuronaXCapa,puntos);
            var funcion = new BipolarSigmoidFunction(2);
            outputs = Accord.Statistics.Tools.Expand(labels, numeroSalidas, -1, 1);
            red = new ActivationNetwork(funcion, numeroEntradas, capas);
           
        }

        private void convierte(List<int> neuronaXCapa, List<Punto> puntos) 
        {
            int i = 0;
            int len = puntos.Count;
            input = new double[len][];
            labels = new int[len];
            capas = new int[neuronaXCapa.Count];

            foreach(Punto p in puntos)
            {
                input[i] = new double[] { p.getPosicionAdaptadaX(), p.getPosicionAdaptadaY() };
                labels[i] = p.getTipo();
                i++;

            }
            i = 0;
            foreach (int capa in neuronaXCapa) 
            {
                capas[i] = capa;
                i++;
            }
            i = i - 1;
            numeroSalidas = capas[i];

        }

        public async Task entrenar(Bitmap bitmap_plano, Bitmap respaldo, Bitmap bitmap_solo_plano, Form callingForm, List<Pen> plumas)
        {
            ImgControl = new Img_control(bitmap_plano, respaldo, bitmap_solo_plano, plumas, callingForm);
            ImgControl.LimpiarPLano();
            double error = Double.PositiveInfinity;
            new NguyenWidrow(red).Randomize();
            var lm = new LevenbergMarquardtLearning(red);
            lm.LearningRate = lr;
            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < epocasMaximas; i++)
                {
                    error = lm.RunEpoch(input, outputs);
                    ImgControl.ActualizarGraficaError("MLP LM", i, error);
                    if (error < errorDeseado)
                    {
                        i = epocasMaximas;
                    }
                }
            });
            ImgControl.Dibujar_bitmap_lv(this, lista_puntos);
        }

        public int prueba(Punto p) 
        {
            double[] entrada = new double[] { p.getPosicionAdaptadaX(), p.getPosicionAdaptadaY() };
            double[] salida = red.Compute(entrada);
            var list = salida.ToList<double>();
            var max = list.Max();
            Console.WriteLine(salida.ToArray<double>());
            var clase=list.IndexOf(max);
            return clase;
            
        }
    }
}
