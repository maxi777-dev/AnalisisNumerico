using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Unidad1
{
    public class Actividad1 : Entrada
    {
        //public Actividad1(int citer, int tole, float xi, float xd)
        //{
        //    Iter = citer;
        //    Tole = tole;
        //    XI = xi;
        //    XD = xd;
        //}

        public static float funcion(float x)
        {
            return (float)(8 * x - 7); //----------> 8X - 7
            //return (float)((Math.Pow(x, 3) + 5)); ---> X^3 + 5
            //return (float)((Math.Pow(x,3)) - (5 * x) + 6); -----------> X^3 - 5X + 6
            //return (float)((Math.Pow(x, 5)) + (4 * (Math.Pow(x, 2))) + x - 5);  --------> x^5 + 4x^2 + x -5

            //return 0;

        }

        public static Resultado Biseccion(int citer, double tole, float xi, float xd)
        {
            Resultado nuevo = new Resultado(0, tole, 0, true, "");
            double operacion = funcion(xi) * funcion(xd);
            if (operacion < 0)
            {
                bool band = false; float error = 0;
                int contador = 0;
                float xant = 0;
                float xr = (xi + xd) / 2;
                if ((xi + xd) == 0)
                    error = 1;
                else
                    error = Math.Abs((xr - xant) / xr);
                while (Math.Abs(funcion(xr)) >= tole && contador < citer && error > tole && band == false)
                {
                    contador += 1;
                    xr = (xi + xd) / 2;
                    if ((xi + xd) == 0)
                        error = 1;
                    else
                        error = Math.Abs((xr - xant) / xr);
                    if (Math.Abs(funcion(xr)) < tole || contador > citer || error < tole)
                    {
                        nuevo.Solucion = xr;
                        nuevo.Iter = contador;
                        nuevo.Tole = error;
                        band = true;
                    }
                    else
                    {
                        if (funcion(xi) * funcion(xr) < 0)
                        {
                            xd = xr;
                        }
                        else
                        {
                            xi = xr;
                        }
                        xant = xr;
                    }
                }
            }
            else
            {
                if (operacion == 0)
                {
                    if (funcion(xi) == 0)
                        nuevo.Solucion = xi;

                    else
                        nuevo.Solucion = xd;
                }
                else
                {
                    nuevo.SePudo = false;
                    nuevo.Mensaje = "Limite Derecho o Izquierdo incorrectos, por favor ingreselos nuevamente";
                }

            }
            return nuevo;
        }

        public static Resultado ReglaFalsa(int citer, double tole, float xi, float xd)
        {
            Resultado nuevo = new Resultado(0, tole, 0, true, "");

            double operacion = funcion(xi) * funcion(xd);
            if (operacion < 0)
            {
                bool band = false; float error = 0;
                int contador = 0;
                float xant = 0;
                float xr = ((-funcion(xd) * xi) + (funcion(xi) * xd)) / (funcion(xi) - funcion(xd));
                if ((xi + xd) == 0)
                    error = 1;
                else
                    error = Math.Abs((xr - xant) / xr);
                while (Math.Abs(funcion(xr)) >= tole && contador < citer && error > tole && band == false)
                {
                    contador += 1;
                    xr = ((-funcion(xd) * xi) + (funcion(xi) * xd)) / (funcion(xi) - funcion(xd));
                    if ((xi + xd) == 0)
                        error = 1;
                    else
                        error = Math.Abs((xr - xant) / xr);
                    if (Math.Abs(funcion(xr)) < tole || contador > citer || error < tole)
                    {
                        nuevo.Solucion = xr;
                        nuevo.Iter = contador;
                        nuevo.Tole = error;
                        band = true;
                    }
                    else
                    {
                        //if (funcion(xi) * funcion(xr) < 0)
                        //{
                        //    xd = xr;
                        //}
                        //else
                        //{
                        //    xi = xr;
                        //}
                        xant = xr;
                    }
                }
            }
            else
            {
                if (operacion == 0)
                {
                    if (funcion(xi) == 0)
                        nuevo.Solucion = xi;

                    else
                        nuevo.Solucion = xd;
                }
                else
                {
                    nuevo.SePudo = false;
                    nuevo.Mensaje = "Limite Derecho o Izquierdo incorrectos, por favor ingreselos nuevamente";
                }

            }

            return nuevo;
        }
    }
}
