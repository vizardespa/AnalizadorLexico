using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorSintactico
{
    public class Regla
    {
        string TipoR { get; set; }
        string TipoC { get; set; }
        List<string> Estructura { get; set; }

        public Regla()
        {
                
        }
        public Regla(string tipoR, string tipoC, List<string> estructura)
        {
            TipoR = tipoR;
            TipoC = tipoC;
            Estructura = estructura;
        }
    }
}
