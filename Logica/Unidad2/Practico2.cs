using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Unidad2
{
    public class Practico2
    {
        public static double[] Escalonar(double[,] matriz, int incognitas)
        {
            double[] v = new double[incognitas];
            for (int i = 0; i < incognitas; i++)
            {
                double coeficiente = matriz[i, i];
                for (int j = 0; j < incognitas + 1; j++)
                {
                    matriz[i, j] = matriz[i, j] / coeficiente;
                }

                for (int j = 0; j < incognitas; j++)
                {
                    if (j != i)
                    {
                        coeficiente = matriz[j, i];
                        for (int k = 0; k < incognitas + 1; k++)
                        {
                            matriz[j, k] = matriz[j, k] - (coeficiente * matriz[i, k]);
                        }
                    }
                }
            }
            for (int i = 0; i < incognitas; i++)
            {
                v[i] = matriz[i, incognitas];
            }
            return v;
        }
        public static double[,] Pivoteo_Parcial(double[,] matriz, int incognitas)
        {
            double mayor = 0;
            int posicion = 0;
            //double[] v = new double[incognitas + 1];
            for (int i = 0; i < incognitas; i++)
            {
                if (i == 0)
                {
                    mayor = Math.Abs(matriz[i, 1]);
                    posicion = 0;
                }                    
                else
                {
                    if (Math.Abs(matriz[i, 1]) > mayor)
                    {
                        posicion = i;
                        mayor = Math.Abs(matriz[i, 1]);
                    }
                }
            }
            if (posicion != 0)
            {
                double aux;
                for (int i = 0; i < (incognitas + 1); i++)
                {
                    aux = matriz[0, i];
                    matriz[0, i] = matriz[posicion, i];
                    matriz[posicion, i] = aux;
                }
            }
            
            return matriz;
        }

        public static Resultado_2 Gauss_Jordan(double[,] matriz, int incognitas)
        {
            Resultado_2 nuevo = new Resultado_2(true, "Los valores de las inognitas son los siguientes: ");
            matriz = Pivoteo_Parcial(matriz, incognitas);
            nuevo.Resultados = Escalonar(matriz, incognitas);
            return nuevo;
        }

        public static Resultado_2 Gauss_Seidel(double[,] matriz, int incognitas)
        {
            Resultado_2 nuevo = new Resultado_2(true, "Los valores de las incognitas son los siguientes: ");
            double[] V_arranque = new double[incognitas];
            for (int i = 0; i < incognitas; i++)
            {
                V_arranque[i] = 0;
            }

            return nuevo;
        }
    }
}
