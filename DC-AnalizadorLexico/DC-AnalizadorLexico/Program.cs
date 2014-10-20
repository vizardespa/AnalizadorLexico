using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DC_AnalizadorLexico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Categoria> Categorias = new List<Categoria>();
            
            //Variables...
            //Entero
            Regex enteroR = new Regex(@"[0-9]+");
            string enteroN = "[Entero]";
           
            //Real
            Regex realR = new Regex(@"[0-9]+\.[0-9]+");
            string realN = "[Real]";
            
            //Identificador
            Regex identificadorR = new Regex(@"[a-zA-Z][a-zA-Z0-9]*");
            string identificadorN = "[Identificador]";
            
            //Asignacion
            Regex asignacionR = new Regex(@"=");
            string asignacionN = "[Asignacion]";
           
            //Rango
            Regex rangoR = new Regex(@"\.\.");
            string rangoN = "[Rango]";
           
            //Blanco
            Regex blancoR = new Regex(@"[\n\s\t]+");
            string blancoN = "[Blanco]";

            #region PrimerIntentoFunciones
            //Funciones...
            //Entero
            Func<string, string> enteroS = (input) =>
            {
                string aux = "";
                return aux;
            };
            //Real
            Func<string, string> realS = (input) =>
            {
               string aux = "";
                return aux;
            };
            //Identificador
            Func<string, string> identificadorS = (input) =>
            {
                string aux = "";
                return aux;
            };
            //Asignacion
            Func<string, string> asignacionS = (input) =>
            {
                string aux = "";
                return aux;
            };
            //Rango
            Func<string, string> rangoS = (input) =>
            {
                string aux = "";
                return aux;
            };
            //Blanco
            Func<string, string> blancoS = (input) =>
            {
                string aux = "";
                return aux;
            };
            #endregion
            Categorias.Add(new Categoria(identificadorN, identificadorR,identificadorS));
            Categorias.Add(new Categoria(asignacionN, asignacionR,asignacionS));
            Categorias.Add(new Categoria(realN, realR,realS));
            Categorias.Add(new Categoria(enteroN, enteroR,enteroS));
            Categorias.Add(new Categoria(rangoN, rangoR,rangoS));
            Categorias.Add(new Categoria(blancoN, blancoR,blancoS));
            /*
            Categorias.Add(new Categoria(identificadorN, identificadorR));
            Categorias.Add(new Categoria(asignacionN, asignacionR));
            Categorias.Add(new Categoria(realN, realR));
            Categorias.Add(new Categoria(enteroN, enteroR));
            Categorias.Add(new Categoria(rangoN, rangoR));
            Categorias.Add(new Categoria(blancoN, blancoR));
             */
            while (true)
            {
                Console.WriteLine("Escribe una entrada...");
                string input = Console.ReadLine();
                List<string> TokensIniciales = new List<string>();
                List<string> TokensFinales = new List<string>();

                #region SeparacionTokens
                string aux = "";
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ')
                    {
                        aux += input[i];
                    }
                    else
                    {
                        TokensIniciales.Add(aux);
                        TokensIniciales.Add(" ");
                        aux = "";
                    }
                }
                TokensIniciales.Add(aux);
                #endregion 

                #region IdentificacionTokens
                foreach (string s in TokensIniciales)
                {
                    bool r = false;
                    foreach (Categoria C in Categorias)
                    {
                        Match maux = C.regex.Match(s);
                        if (maux.Success)
                        {
                            TokensFinales.Add(C.nombre);
                            r = true;
                            break;
                        }
                    }
                    if (!r)
                    {
                        TokensFinales.Add("[TokenNoIdentificado]");
                    }
                }
                #endregion

                Console.WriteLine("Salida en Tokens");
                TokensFinales.ForEach(x => { Console.Write(x); });
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
