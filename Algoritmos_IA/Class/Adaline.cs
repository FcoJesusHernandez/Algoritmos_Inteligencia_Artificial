using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSharp;

namespace Algoritmos_IA.Class
{
    class Adaline
    {
        Array w;
        List<Punto> puntos;
        int epocas, epoca_actual;
        float LR;
        double error_esperado;
        bool entrenado;
        bool completo; // puede estar completo pero no entrenado (cuando se cumplen las iteraciones y aun se mantiene un error
        double error_acumulado;
        double error_actual_epoca;





        public Adaline(int epocas, float LR, List<Punto> puntosEntrenamiento, int epoca_actual)
        {
            completo = false;
            entrenado = false;
            this.epoca_actual = epoca_actual;
            this.epocas = epocas;
            this.LR = LR;
            this.puntos = puntosEntrenamiento;
            error_acumulado = 0;
            
        }
        

        

        public Array inicializar()
        {
            w = (Array)np.random.rand(1, 3);
            w.SetValue(-1, 0, 0);

            return w;
        }

        public void setEntrenado(bool entrenado)
        {
            this.entrenado = entrenado;
        }

        public double funcion_sigmoide(Array x)
        {
            return 1 / (1 + (Math.Exp(-np.matmul((NDArray)w, (NDArray)x).GetDouble())));
        }

        public double funcion_sigmoide_derivada(Array x)
        {
            return 1 / (1 + (Math.Exp(-np.matmul((NDArray)w, (NDArray)x).GetDouble())));
        }

        public double getError_esperado()
        {
            return error_esperado;
        }
        public void setError_esperado(double error_esperado_temp)
        {
            error_esperado = error_esperado_temp;
        }

        public int getEpocas()
        {
            return epocas;
        }

        public bool getEntrenado()
        {
            return entrenado;
        }

        public Array getPesos()
        {
            return w;
        }

        public void setPeso(Array nuevo_w)
        {
            w = nuevo_w;
        }

        public int getEpocaActual()
        {
            return epoca_actual;
        }

        public void setEpocaActual(int epoca_actual)
        {
            this.epoca_actual = epoca_actual;
        }

        public List<Punto> getPuntos()
        {
            return puntos;
        }

        public float getLR()
        {
            return LR;
        }

        public void setErrorAcumulado(double error_acumulado)
        {
            this.error_acumulado = error_acumulado;
        }

        public double getErrorAcumulado()
        {
            return error_acumulado;
        }

        public void setErrorActualEpoca(double error_epoca)
        {
            error_actual_epoca = error_epoca;
        }

        public double getErrorActualEpoca()
        {
            return error_actual_epoca;
        }

        public bool getCompletado()
        {
            return completo;
        }

        public void setCompletado(bool completado)
        {
            completo = completado;
        }

    }
}
