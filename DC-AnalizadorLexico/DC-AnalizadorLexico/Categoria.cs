using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DC_AnalizadorLexico
{
    public class Categoria
    {
        public string nombre { get; set; }
        public Regex regex { get; set; }
        public Func<string, string> separador { get; set; }
        public Categoria(string _nombre, Regex _regex, Func<string, string> _separador)
        {
            nombre = _nombre;
            regex = _regex;
            separador = _separador;
        }
        public Categoria(string _nombre, Regex _regex)
        {
            nombre = _nombre;
            regex = _regex;
        }
        public bool identificar(string input)
        {
            Match m = regex.Match(input);
            return m.Success;
        }
    
    }
}
