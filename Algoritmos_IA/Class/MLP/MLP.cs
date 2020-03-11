﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumSharp;

namespace Algoritmos_IA.Class.MLP
{
    class MLP
    {
        List<Punto> entradas;
        List<Capa> capas;
        bool primerForward = true;
        NDArray matrizDeseadas;
        float learningRate;
        int epocas;
        double errorAcumulado;

        public MLP(int epocas, int nCapas, List<int> neuronaXCapa, float lr, List<Punto> puntos)
        {
            this.epocas = epocas;
            this.entradas = puntos;
            this.learningRate = lr;
            capas = new List<Capa>();
            for (int i = 0; i < nCapas; i++)
            {
                Capa c;
                c = new Capa(neuronaXCapa[i]);
                capas.Add(c);
            }
            matrizDeseadas = np.eye(neuronaXCapa[nCapas - 1]);
        }

        public double funcion_sigmoide(double net)
        {
            return 1 / (1 + (Math.Exp(-net)));
        }

        public double funcion_sigmoide_derivada(double net)
        {
            double sigmoide = funcion_sigmoide(net);
            return sigmoide*(1-sigmoide);
        }

        public void Forward_Backward() 
        {
            
            for(int i = 0; i < epocas; i++) 
            {
                //if error
                errorAcumulado = 0;
                foreach (Punto p in entradas)
                {
                    Forward(p,false);
                    BackPropagation(p);
                }
                Console.WriteLine("Error Acumulado por Epoca: ");
                Console.WriteLine(errorAcumulado/entradas.Count);
            }
            
        }
        public void Forward( Punto p, bool evaluar) 
        {
            double[] entrada;
            entrada = new double[3];
            entrada[0] = -1;
            entrada[1] = p.getPosicionAdaptadaX();
            entrada[2] = p.getPosicionAdaptadaY();
            NDArray net;
            


            foreach (Capa c in capas)
            {

                if (primerForward)
                {
                    foreach (Neurona a in c.listaNeuronas)
                    {
                        a.inicializaPesos(entrada.Length);
                    }
                }
                else if (!evaluar)
                {
                    /*List<double> salida = new List<double>();
                    for (int i = 1; i < entrada.Length; i++) 
                    {
                        salida.Add(entrada[i]);
                    }*/
                    c.actualizaPesos(learningRate, entrada);
                    
                }
                net = np.dot(c.getPesosCapa(), entrada);

                c.netCapa = net;
                
                List<double> a_salida = new List<double>();

                if (net.Shape.Size == 1) 
                {
                    a_salida.Add(funcion_sigmoide(net));
                }
                else 
                {
                    for (int i = 0; i < net.Shape.Dimensions[0]; i++)
                    {
                        a_salida.Add(funcion_sigmoide(net[i]));
                    }
                }
                
                c.salidaCapa = a_salida.ToArray();

                a_salida.Insert(0, -1);

                entrada = a_salida.ToArray();

                if (evaluar) 
                {
                    Console.WriteLine(c.salidaCapa.ToString());
                }
            }
            primerForward = false;
        }

        public void BackPropagation(Punto p) 
        {
            bool primerCapa = true;
            
            capas.Reverse();

            Capa anterior=capas.First<Capa>();

            foreach (Capa c in capas)
            {
                
                if (primerCapa)
                {
                    NDArray deseada = matrizDeseadas[p.getTipo()];
                    var error = deseada - c.salidaCapa;
                    double acum = 0;
                    for (int i = 0; i < error.size; i++) 
                    {
                        acum += error[i];
                    }
                    errorAcumulado += Math.Pow(acum, 2);
                    List<double> gradiente = new List<double>();
                    for (int i = 0; i < c.netCapa.Shape.Dimensions[0]; i++)
                    {
                        gradiente.Add(funcion_sigmoide_derivada(c.netCapa[i]));
                    }
                    var s = np.multiply(-2, gradiente.ToArray());
                    var sensibilidad = np.multiply(s, error);
                    c.sensibilidadCapa = sensibilidad;
                    anterior = c;
                    primerCapa = false;
                }
                else 
                {
                    List<double> gradiente = new List<double>();
                    if (c.netCapa.Shape.Size == 1)
                    {
                        gradiente.Add(funcion_sigmoide_derivada(c.netCapa));
                    }
                    else
                    {
                        for (int i = 0; i < c.netCapa.Shape.Dimensions[0]; i++)
                        {
                            gradiente.Add(funcion_sigmoide_derivada(c.netCapa[i]));
                        }
                    }
                    var unos = np.eye(gradiente.Count);
                    var identidad = np.multiply(gradiente.ToArray(), unos);
                    var transpuesta = anterior.getPesosSinCero();
                    var ws = np.matmul(transpuesta, anterior.sensibilidadCapa);
                    var sensibilidad = np.matmul(identidad, ws);
                    c.sensibilidadCapa = sensibilidad;
                    anterior = c;
                }
            }
            capas.Reverse();
        }  
    }
}
