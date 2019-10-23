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
            Resultado_4 nuevo = new Resultado_4("",true);
            double fx;
            Calculo AnalizadorDeFuncion = new Calculo();
            if (!AnalizadorDeFuncion.Sintaxis(func, 'x'))
            {
                nuevo.SePudo = false;
                nuevo.Mensaje = "Expresion no valida";
            }
            return nuevo;
        }

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

        public static Resultado_4 Trapecio_Multiple(string funcion)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {

            }
            return nuevo;
        }

        public static Resultado_4 Un_Tercio_Simple(string funcion)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {

            }
            return nuevo;
        }

        public static Resultado_4 Un_Tercio_Multiple(string funcion)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {

            }
            return nuevo;
        }

        public static Resultado_4 Tres_Octavos(string funcion)
        {
            Resultado_4 nuevo = Analizador(funcion);
            if (nuevo.SePudo)
            {

            }
            return nuevo;
        }
    }
}
