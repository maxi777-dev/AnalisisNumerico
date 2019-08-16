using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Resultado
    {
        public int Iter { get; set; }
        public double Tole { get; set; }
        public double Solucion { get; set; }
        public bool SePudo { get; set; }
        public string Mensaje { get; set; }

        public Resultado(int i, double tol, double sol, bool band, string men)
        {
            Iter = i;
            Tole = tol;
            Solucion = sol;
            SePudo = band;
            Mensaje = men;
        }
    }
}
