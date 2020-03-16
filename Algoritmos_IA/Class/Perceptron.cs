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
        readonly List<Punto> puntos;
        private readonly int epocas;
        private int epoca_actual;
        readonly float LR;
        bool entrenado;
        bool completo; // puede estar completo pero no entrenado (cuando se cumplen las iteraciones y aun se mantiene un error
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

        public Array Inicializar(){
            w = (Array)np.random.rand(1,3);
            w.SetValue(-1,0,0);

            return w;
        }

        public void SetEntrenado(bool entrenado)
        {
            this.entrenado = entrenado;
        }

        public int FuncionEscalon(Array x)
        {
            if(np.matmul((NDArray)w, (NDArray)x).GetDouble() >= 0){
                return 1;
            }
            else{
                return 0;
            }
        }

        public int GetEpocas()
        {
            return epocas;
        }

        public bool GetEntrenado()
        {
            return entrenado;
        }

        public Array GetPesos(){
            return w;
        }

        public void SetPeso(Array nuevo_w)
        {
            w = nuevo_w;
        }

        public int GetEpocaActual()
        {
            return epoca_actual;
        }

        public void SetEpocaActual(int epoca_actual)
        {
            this.epoca_actual = epoca_actual;
        }

        public List<Punto> GetPuntos()
        {
            return puntos;
        }

        public float GetLR()
        {
            return LR;
        }

        public void SetErrorAcumulado(int error_acumulado)
        {
            this.error_acumulado = error_acumulado;
        }

        public int GetErrorAcumulado()
        {
            return error_acumulado;
        }

        public bool GetCompletado()
        {
            return completo;
        }

        public void SetCompletado(bool completado)
        {
            completo = completado;
        }
    }
}
