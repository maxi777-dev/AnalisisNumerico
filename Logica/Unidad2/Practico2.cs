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
            for (int i = 0; i < incognitas; i++)
            {
                if (i == 0)
                {
                    mayor = Math.Abs(matriz[i, 0]);
                    posicion = 0;
                }                    
                else
                {
                    if (Math.Abs(matriz[i, 0]) > mayor)
                    {
                        posicion = i;
                        mayor = Math.Abs(matriz[i, 0]);
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
        public static double Determinante(double[,] matriz, int incognitas)
        {
            double resultado = 0;
            switch (incognitas)
            {
                case 2: return matriz[0, 0] * matriz[1, 1] - matriz[1, 0] * matriz[0, 1];
                default:
                    double[,] auxiliar = new double[incognitas - 1, incognitas -1];
                    for (int i = 0; i < incognitas; i++)
                    {
                        auxiliar = MatrizCofactores(matriz, incognitas - 1, i);
                        resultado += Math.Pow(-1,i) * matriz[0,i] * Determinante(auxiliar, incognitas - 1);
                    }
                    return resultado;
            }
        }
        public static double[,] MatrizCofactores(double[,] matriz, int incognitas, int i)
        {
            double[,] matriz_aux = new double[incognitas, incognitas];
            int x = 0;
            int y = 0;
            for (int j = 0; j < incognitas + 1; j++)
            {
                for (int k = 0; k < incognitas + 1; k++)
                {
                    if (j != 0 && k != i)
                    {
                        matriz_aux[x, y] = matriz[j, k];
                        if (y < incognitas - 1)
                        { y += 1; }
                        else
                        { x += 1; y = 0; };
                    }
                }
            }
            return matriz_aux;
        }

        //--------------------------------------------  METODOS  ----------------------------------------------------//
        public static Resultado_2 Gauss_Jordan(double[,] matriz, int incognitas, bool pivoteo)
        {
            Resultado_2 nuevo = new Resultado_2(true, "Los valores de las incognitas son los siguientes: ", incognitas, 0);
            if (Determinante(matriz, incognitas) != 0)
            {
                if (pivoteo)
                    matriz = Pivoteo_Parcial(matriz, incognitas);
                nuevo.Resultados = Escalonar(matriz, incognitas);
                if (nuevo.Resultados[0] is Double.NaN)
                { nuevo.SePudo = false; nuevo.Mensaje = "El elemento pivotal es 0"; }
            }
            else
            {
                nuevo.Mensaje = "El sistema no tiene resolución";
                nuevo.SePudo = false;
            }
            return nuevo;
        }
        public static Resultado_2 Gauss_Seidel(double[,] matriz, int incognitas, int iteraciones, double tole, bool pivoteo)
        {
            Resultado_2 nuevo = new Resultado_2(true, "Los valores de las incognitas son los siguientes: ", incognitas,0);

            if (Determinante(matriz, incognitas) != 0)
            {
                double[] V_arranque = new double[incognitas];
                for (int i = 0; i < incognitas; i++)
                {
                    V_arranque[i] = 0;
                }

                if (pivoteo)
                    matriz = Pivoteo_Parcial(matriz, incognitas);

                double suma; double divisor;
                int cont_iter = 0;
                bool band = false;
                double[] V_ant = new double[incognitas];
                while ((cont_iter < iteraciones) && !band)
                {
                    for (int i = 0; i < incognitas; i++)
                    {
                        V_ant[i] = V_arranque[i];
                    }

                    for (int i = 0; i < incognitas; i++)
                    {
                        suma = 0; divisor = 0;
                        for (int j = 0; j < incognitas; j++)
                        {
                            if (i != j)
                                suma += matriz[i, j] * V_arranque[j];
                            else
                                divisor = matriz[i, j];
                        }
                        V_arranque[i] = (matriz[i, incognitas] - suma) / divisor;
                    }
                    cont_iter += 1;
                    double resta = 0;
                    int c = 0;
                    for (int i = 0; i < incognitas; i++)
                    {
                        resta = V_arranque[i] - V_ant[i];
                        if (Math.Abs(resta) < tole)
                            c += 1;
                    }
                    if (c == incognitas)
                        band = true;
                }
                if (!band)
                {
                    nuevo.Mensaje = "Se ha excedido el numero de iteraciones, no se ha llegado a una solucion valida";
                    nuevo.SePudo = false;
                }
                for (int i = 0; i < incognitas; i++)
                {
                    nuevo.Resultados[i] = V_arranque[i];
                }
                nuevo.Iter = cont_iter;
            }
            else
            {
                nuevo.Mensaje = "El sistema no tiene resolución";
                nuevo.SePudo = false;
            }
            return nuevo;
        }
    }
}