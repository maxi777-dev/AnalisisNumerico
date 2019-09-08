using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Unidad2
{
    public class Resultado_2
    {
        public Resultado_2(bool b)
        {
            SePudo = b;
        }

        public bool SePudo { get; set; }
        public string Mensaje { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int T { get; set; }
        public int S { get; set; }

    }
}
