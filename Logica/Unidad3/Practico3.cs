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

        public void RegresionPolinomial(int[] VectorX, int[] VectorY, int n, int Grado)
        {
            int SumX = 0; int SumY = 0;
            double[,] Matriz = new double[Grado - 1, Grado];
            for (int i = 0; i < n - 1; i++)
            {
                SumX += VectorX[i];
                SumY += VectorY[i];
                for (int j = 0; j < Grado; j++)
                {
                    for (int k = 0; k < Grado; k++)
                    {
                        Matriz[j, k] += Math.Pow(VectorX[i], (k + j));
                    }
                    Matriz[j, Grado + 1] += VectorY[i] * (Math.Pow(VectorX[i], j));
                }
            }
            //R[] = GaussJordan(Matriz[], Grado + 1);
        }

        

    }
}
