﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Unidad2
{
    public class Resultado_2
    {
        public Resultado_2(bool b, string s)
        {
            SePudo = b;
            Mensaje = s;
        }

        public bool SePudo { get; set; }
        public string Mensaje { get; set; }
        public double[] Resultados { get; set; }

    }
}
