using System;
using System.Collections.Generic;
using System.Linq;
using Calculus;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Unidad4
{
    public class Practico4
    {
        private static Resultado_4 Analizador(string func)
        {
            Resultado_4 nuevo = new Resultado_4("El Area debajo de la funcion es: ",true);
            double fx;
            Calculo AnalizadorDeFuncion = new Calculo();
            if (!AnalizadorDeFuncion.Sintaxis(func, 'x'))
            {
                nuevo.SePudo = false;
                nuevo.Mensaje = "Expresion no valida";
            }
            return nuevo;
        }
        
        //-------------------------------------------------------    METODOS   ---------------------------------------------------------------//
        public static Resultado_4 Trapecio_Simple(string funcion, double a, double b)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {
                double Fa = Unidad1.Actividad1.Fx(funcion, a);
                double Fb = Unidad1.Actividad1.Fx(funcion, b);
                nuevo.Solucion = ((Fa + Fb) * (b - a)) / 2;
            }
            return nuevo;
        }
        public static Resultado_4 Trapecio_Multiple(string funcion, double a, double b, int n)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {
                double h = (b - a) / n;
                double sumatoria = 0; double xi = 0;
                for (int i = 1; i <= n - 1; i++)
                {
                    xi = a + (i * h);
                    sumatoria += Unidad1.Actividad1.Fx(funcion, xi);
                }
                sumatoria += sumatoria;
                double fx0 = Unidad1.Actividad1.Fx(funcion, a);
                double fxn = Unidad1.Actividad1.Fx(funcion, b);
                nuevo.Solucion = (h / 2) * (fx0 + sumatoria + fxn);
            }
            return nuevo;
        }
        public static Resultado_4 Un_Tercio_Simple(string funcion, double a, double b)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {
                double h = (b - a) / 2;
                double fx0 = Unidad1.Actividad1.Fx(funcion, a);
                double fx1 = Unidad1.Actividad1.Fx(funcion, (a + h));
                double fx2 = Unidad1.Actividad1.Fx(funcion, b);
                nuevo.Solucion = (h / 3) * (fx0 + (4 * fx1) + fx2);
            }
            return nuevo;
        }
        public static Resultado_4 Un_Tercio_Multiple(string funcion, double a, double b, int n)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {
                double h = (b - a) / n;
                double fx0 = Unidad1.Actividad1.Fx(funcion, a);
                double fxn = Unidad1.Actividad1.Fx(funcion, b);
                double sum_fximpares = 0; double sum_fxpares = 0; double xi = 0;

                for (int i = 1; i <= n - 1; i = i + 2) //SUMATORIA IMPARES
                {
                    xi = a + (i * h);
                    sum_fximpares += Unidad1.Actividad1.Fx(funcion, xi);                    
                }

                for (int i = 2; i <= n - 2; i = i + 2) //SUMATORIA PARES
                {
                    xi = a + (i * h);
                    sum_fxpares += Unidad1.Actividad1.Fx(funcion, xi);
                }

                nuevo.Solucion = (h / 3) * (fx0 + (4 * sum_fximpares) + (2 * sum_fxpares) + fxn);
            }
            return nuevo;
        }
        public static Resultado_4 Tres_Octavos(string funcion, double a, double b)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {
                double h = (b - a) / 3;
                double fx0 = Unidad1.Actividad1.Fx(funcion, a);
                double fx1 = Unidad1.Actividad1.Fx(funcion, (a + h));
                double fx2 = Unidad1.Actividad1.Fx(funcion, (a + (2 * h)));
                double fx3 = Unidad1.Actividad1.Fx(funcion, b);
                nuevo.Solucion = ((3 * h) / 8) * (fx0 + (3 * fx1) + (3 * fx2) + fx3);
            }
            return nuevo;
        }
    }
}
