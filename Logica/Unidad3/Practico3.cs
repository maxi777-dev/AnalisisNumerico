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

        public static Logica.Unidad2.Resultado_2 ResolucionMC(double[] VectorX, double[] VectorY, int n, int Grado)
        {
            //Obtengo el sistema de ecuaciones
            double[,] auxiliar = Logica.Unidad3.Practico3.RegresionPolinomial(VectorX, VectorY, n, Grado);

            //Obtengo los valores del sistema de ecuaciones
            Logica.Unidad2.Resultado_2 res = Logica.Unidad2.Practico2.Gauss_Jordan(auxiliar, Grado, false);

            //Con los valores anteriores, calcular sr y st para poder calcular el coeficiente de correlación
            double sumatoriaY = 0, sr= 0, st= 0, sr_temp;
            for (int i = 0; i < n; i++)
            { sumatoriaY += VectorY[i]; }
            for (int i = 0; i < n; i++)
            {
                sr_temp = VectorY[i] - VectorX[i] * res.Resultados[1] - res.Resultados[0];
                sr_temp -= Grado > 4 ? Math.Pow(VectorX[i], 4) * res.Resultados[4] : 0;
                sr_temp -= Grado > 3 ? Math.Pow(VectorX[i], 3) * res.Resultados[3] : 0;
                sr_temp -= Grado > 2 ? Math.Pow(VectorX[i], 2) * res.Resultados[2] : 0;

                sr += Math.Pow(sr_temp, 2);
                st += Math.Pow(VectorY[i] - (sumatoriaY/n),2);
            }

            //Evaluar coeficiente de correlación
            res.Bandera_3 = ((st - sr) / st) * 100;            
            return res;
        }
    }
}
