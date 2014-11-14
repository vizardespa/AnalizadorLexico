using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorSintactico
{
    public class Regla
    {
        public string TipoR { get; set; }
        public string TipoC { get; set; }
        public List<string> Estructura { get; set; }

        public Regla()
        {
            Estructura = new List<string>();
        }
        public Regla(string tipoR, string tipoC, List<string> estructura)
        {
            TipoR = tipoR;
            TipoC = tipoC;
            Estructura = estructura;
        }
    }
}
