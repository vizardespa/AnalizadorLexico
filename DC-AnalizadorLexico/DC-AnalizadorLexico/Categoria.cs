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
        public Func<string, string> Separador { get; set; }
        public Categoria(string _nombre, Regex _regex, Func<string, string> _separador)
        {
            nombre = _nombre;
            regex = _regex;
            Separador = _separador;
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
        /*
       public string[] Separadortokens(string input)
        {
            string[] tokens = Regex.Split(input,regex.ToString());
            return tokens;
        }*/
    
    }
}
