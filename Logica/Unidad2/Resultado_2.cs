using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Unidad2
{
    public class Resultado_2
    {
        public Resultado_2(bool b, string s, int inc, int iter)
        {
            SePudo = b;
            Mensaje = s;
            Resultados = new double[inc];
            Iter = iter;
            Bandera_3 = 0;
        }

        public int Iter { get; set; }
        public bool SePudo { get; set; }
        public string Mensaje { get; set; }
        public double[] Resultados { get; set; }
        public double Bandera_3 { get; set; }

    }
}
