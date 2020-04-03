using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_IA.Class
{
    public class elemento_importado
    {
        public double tipo { set; get; }
        public List<double> listaValoresEntrada { set; get; }
        public double[] arregloValoresEntrada { set; get; }

        public List<double> listaValoresEntradaNormalizada { set; get; }
        public double[] arregloValoresEntradaNormalizada { set; get; }

        public elemento_importado(List<double> entradas, double clase)
        {
            listaValoresEntrada = new List<double>(entradas);
            arregloValoresEntrada = listaValoresEntrada.ToArray();
            tipo = clase;
        }
    }

    public class importacion
    {
        public string nombreArchivo { get; set; }
        public List<double> clasesDetectadas { get; set; }
        public int tamanoColumnas { get; set; }
        public int tamanoFilas { get; set; }
        public List<elemento_importado> elementosImportados { get; set; }
        public List<string> nombresColumnas { get; set; }
        public double[] media { get; set; }
        public double[] desviacion { get; set; }
        public double[] varianza { get; set; }

        public importacion(string nombreArchivo, List<elemento_importado> entradas, List<double> clases, int tamanoColumnas, List<string> nombresColumbas)
        {
            this.nombreArchivo = nombreArchivo;
            elementosImportados = new List<elemento_importado>(entradas);
            tamanoFilas = elementosImportados.Count;
            this.tamanoColumnas = tamanoColumnas;
            this.clasesDetectadas = new List<double>(clases);
            this.nombresColumnas = nombresColumnas;

            media = new double[this.tamanoColumnas];
            varianza = new double[this.tamanoColumnas];
            desviacion = new double[this.tamanoColumnas];
            normalizacion();
        }

        public void normalizacion()
        {
            calcularMedia();
            calcularVarianza();
            calcularDesviacion();

            for (int i = 0; i < elementosImportados.Count; i++)
            {
                List<double> temporal_de_entradas = new List<double>();
                for (int j = 0; j < elementosImportados[i].arregloValoresEntrada.Count(); j++)
                {
                    if(desviacion[j] != 0 && ((elementosImportados[i].arregloValoresEntrada[j] - media[j]) / desviacion[j]) != Double.NaN)
                    {
                        temporal_de_entradas.Add((elementosImportados[i].arregloValoresEntrada[j] - media[j]) / desviacion[j]);
                    }
                    else
                    {
                        temporal_de_entradas.Add(0);
                    }
                }
                elementosImportados[i].listaValoresEntradaNormalizada = new List<double>(temporal_de_entradas);
                elementosImportados[i].arregloValoresEntradaNormalizada = elementosImportados[i].listaValoresEntradaNormalizada.ToArray();
            }

            /*
            (X(:, i) - media(i)) / sigma(i);
            arregloValoresEntradaNormalizada
            listaValoresEntradaNormalizada*/
        }

        private void calcularMedia()
        {
            double[] suma = new double[tamanoColumnas];
            int[] poblacion = new int[tamanoColumnas];

            for(int i = 0; i< elementosImportados.Count; i++)
            {
                for (int j = 0; j<elementosImportados[i].arregloValoresEntrada.Count(); j++)
                {
                    suma[j] = suma[j] + elementosImportados[i].arregloValoresEntrada[j];
                    poblacion[j] = poblacion[j] + 1;
                }
            }

            for(int i = 0; i< tamanoColumnas; i++)
            {
                media[i] = suma[i] / poblacion[i];
            }
        }

        private void calcularVarianza()
        {
            int[] poblacion = new int[tamanoColumnas];
            for (int i = 0; i < elementosImportados.Count; i++)
            {
                for (int j = 0; j < elementosImportados[i].arregloValoresEntrada.Count(); j++)
                {
                    varianza[j] = varianza[j] + Math.Pow(elementosImportados[i].arregloValoresEntrada[j] - media[j], 2);
                    poblacion[j] = poblacion[j] + 1;
                }
            }

            for (int i = 0; i < tamanoColumnas; i++)
            {
                varianza[i] = varianza[i] / ( poblacion[i] - 1);
            }
        }

        private void calcularDesviacion()
        {
            for (int i = 0; i < tamanoColumnas; i++)
            {
                desviacion[i] = Math.Sqrt(varianza[i]);
            }
        }
    }
}
