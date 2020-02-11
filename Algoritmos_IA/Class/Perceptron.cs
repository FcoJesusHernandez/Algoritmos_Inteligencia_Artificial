using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSharp;

namespace Algoritmos_IA.Class
{
    class Perceptron
    {
        Array w;
        List<Punto> puntos;
        int epocas, epoca_actual;
        float LR;
        bool entrenado;
        //bool completo; // puede estar completo pero no entrenado (cuando se cumplen las iteraciones y aun se mantiene un error
        int error_acumulado;

        public Perceptron(int epocas, float LR, List<Punto> puntosEntrenamiento, int epoca_actual)
        {
            //completo = false;
            entrenado = false;
            this.epoca_actual = epoca_actual;
            this.epocas = epocas;
            this.LR = LR;
            this.puntos = puntosEntrenamiento;
            error_acumulado = 0;
        }

        public Array inicializar(){
            w = (Array)np.random.rand(1,3);
            w.SetValue(-1,0,0);

            return w;
        }

        public void setEntrenado(bool entrenado)
        {
            this.entrenado = entrenado;
        }

        public int funcionEscalon(Array x)
        {
            if(np.matmul((NDArray)w, (NDArray)x).GetDouble() >= 0){
                return 1;
            }
            else{
                return 0;
            }
        }

        public int getEpocas()
        {
            return epocas;
        }

        public bool getEntrenado()
        {
            return entrenado;
        }

        public Array getPesos(){
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

        public void setErrorAcumulado(int error_acumulado)
        {
            this.error_acumulado = error_acumulado;
        }

        public int getErrorAcumulado()
        {
            return error_acumulado;
        }
    }
}
