using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Unidad3
{
    public class Practico3
    {
        // Regresion Polinomial
        // Vector(x), Vector(y), Cantidad de puntos(n), Grado        

        public static double[,] RegresionPolinomial(double[] VectorX, double[] VectorY, int n, int Grado)
        {
            double SumX = 0, SumY = 0;
            double[,] Matriz = new double[Grado, Grado + 1];
            for (int i = 0; i < n; i++)
            {
                SumX += VectorX[i];
                SumY += VectorY[i];
                for (int j = 0; j < Grado; j++)
                {
                    for (int k = 0; k < Grado; k++)
                    {
                        Matriz[j, k] += Math.Pow(VectorX[i], (k + j));                   
                    }
                    Matriz[j, Grado] += VectorY[i] * (Math.Pow(VectorX[i], j));
                }
            }
            return Matriz;
        }

        public static Unidad2.Resultado_2 Lagrange (double[] VectorX, double[] VectorY, double variable, int Grado)
        {
            Unidad2.Resultado_2 res = new Unidad2.Resultado_2(false, "No se pudo realizar Lagrange", 1, 50);
            int i = 0; double S = 0; double Sa = 0; double Sb = 0;
            while (i <= Grado - 1)
            {
                Sa = 1; Sb = 1;
                for (int j = 0; j < Grado - 1; j++)
                {
                    if (i != j)
                    {
                        Sa = Sa * (variable - VectorX[j]);
                        Sb = Sb * (VectorX[i] - VectorX[j]);
                    }
                }
                S = S + (VectorY[i] * (Sa / Sb));
                i += 1;
            }
            res.SePudo = true;
            res.Resultados[0] = S;
            res.Mensaje = "Lagrange se realizo con exito";
            return res;
        }

        public static Logica.Unidad2.Resultado_2 ResolucionMC(double[] VectorX, double[] VectorY, int n, int Grado, int max_grado)
        {
            //Obtengo el sistema de ecuaciones
            double[,] auxiliar = Logica.Unidad3.Practico3.RegresionPolinomial(VectorX, VectorY, n, Grado);

            //Obtengo los valores del sistema de ecuaciones
            Logica.Unidad2.Resultado_2 res = Logica.Unidad2.Practico2.Gauss_Jordan(auxiliar, Grado, false);
            if (res.SePudo != false)
            {
                //Con los valores anteriores, calcular sr y st para poder calcular el coeficiente de correlación
                double sumatoriaY = 0, sr= 0, st= 0, sr_temp;
                for (int i = 0; i < n; i++)
                { sumatoriaY += VectorY[i]; }
                for (int i = 0; i < n; i++)
                {
                    sr_temp = VectorY[i] - res.Resultados[0];
                    for (int j = max_grado; j > 0; j--)
                    {
                        sr_temp -= Grado - 1 >= j ? Math.Pow(VectorX[i], j) * res.Resultados[j] : 0;
                    }
                    sr += Math.Pow(sr_temp, 2);
                    st += Math.Pow(VectorY[i] - (sumatoriaY/n), 2);
                }

                //Evaluar coeficiente de correlación
                res.valorcoeficiente = ((st - sr) / st) * 100;   
            }
            else
            { res.valorcoeficiente = -1; }
            return res;
        }
    }
}
