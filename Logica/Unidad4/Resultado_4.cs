using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Unidad4
{
    public class Resultado_4
    {

        public Resultado_4(string m, bool b)
        {
            Mensaje = m;
            SePudo = b;
        }

        public string Mensaje { get; set; }
        public double Solucion { get; set; }
        public bool SePudo { get; set; }
    }
}
