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
            List<Categoria> Categorias = CargarCategorias();
            while (true)
            {
                Console.WriteLine("Escribe una entrada...");
                string input = Console.ReadLine();
                input = SeparacionTokensCategorias(Categorias,input);
                List<string> TokensIniciales = SeparacionTokens(input);
                List<string> TokensFinales = IdentificarTokens(Categorias,TokensIniciales);
                Console.WriteLine("Salida en Tokens...");
                TokensFinales.ForEach(x => { Console.Write(x); });
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static List<Categoria> CargarCategorias()
        {
            List<Categoria> Categorias = new List<Categoria>();
            #region CargaVariables
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

            //Letras
            Regex LetrasR = new Regex(@"[a-zA-Z]+");
            string LetrasN = "[Letra]";

            //Simbolos
            Regex SimbolosR = new Regex(@"[+\-*/=!.]+");
            string SimbolosN = "[Simbolo]";

            //Suma
            Regex SumaR = new Regex(@"\+");
            string SumaN = "[Suma]";

            //Resta
            Regex RestaR = new Regex(@"\-");
            string RestaN = "[Resta]";

            //Division
            Regex DivisionR = new Regex(@"/");
            string DivisionN = "[Division]";

            //Multiplicacion
            Regex MultiplicacionR = new Regex(@"\*");
            string MultiplicacionN = "[Multiplicacion]";
            #endregion

            #region Funciones
            //Funciones...
            //Entero
            Func<string, string> enteroS = (input) =>
            {
                /*//aun no terminado
                List<char> inputR = input.ToList<char>();
                bool blanco = false;
                bool NoEntero = true;
                string aux="";
                for (int i = 0; i < input.Length; i++)
                {
                    Match m = enteroR.Match(input[i].ToString());
                    if(NoEntero)
                    {

                    }
                    if (!blanco && m.Success&&!NoEntero)
                    {
                        if (i != 0)
                        {
                            Match n = LetrasR.Match(input[i - 1].ToString());
                            if (!n.Success)
                                blanco = true;
                        }
                    }
                    else if (blanco && !m.Success)
                    {
                        if (i != input.Length - 1)
                        {
                            if (input[i + 1] != '.')
                            {
                                inputR.Insert(i, ' ');
                                blanco = false;
                            }
                        }
                    }
                }
                return string.Join("", inputR);*/
                return input;
            };
            //Real
            Func<string, string> realS = (input) =>
            {
                return input;
            };
            //Identificador
            Func<string, string> identificadorS = (input) =>
            {
                //return SeparadorGenerico(input, identificadorR, "MetodologiaPendiente");
                return input;
            };
            //Asignacion
            Func<string, string> asignacionS = (input) =>
            {
                return SeparadorGenerico(input, asignacionR, "=");
            };
            //Rango
            Func<string, string> rangoS = (input) =>
            {
                return input;
            };
            //Blanco
            Func<string, string> blancoS = (input) =>
            {
                return input;
            };

            //Suma
            Func<string, string> SumaS = (input) =>
            {
                return SeparadorGenerico(input, SumaR, "+");
            };

            //Resta
            Func<string, string> RestaS = (input) =>
            {
                return SeparadorGenerico(input, RestaR, "-");
            };

            //Multiplicacion
            Func<string, string> MultiplicacionS = (input) =>
            {
                return SeparadorGenerico(input, MultiplicacionR, "*");
            };

            //Division
            Func<string, string> DivisionS = (input) =>
            {
                return SeparadorGenerico(input, DivisionR, "/");
            };
            #endregion

            #region AgregacionCategorias
            Categorias.Add(new Categoria(SumaN, SumaR, SumaS));
            Categorias.Add(new Categoria(RestaN, RestaR, RestaS));
            Categorias.Add(new Categoria(DivisionN, DivisionR, DivisionS));
            Categorias.Add(new Categoria(MultiplicacionN, MultiplicacionR, MultiplicacionS));
            Categorias.Add(new Categoria(identificadorN, identificadorR, identificadorS));
            Categorias.Add(new Categoria(asignacionN, asignacionR, asignacionS));
            Categorias.Add(new Categoria(realN, realR, realS));
            Categorias.Add(new Categoria(enteroN, enteroR, enteroS));
            Categorias.Add(new Categoria(rangoN, rangoR, rangoS));
            Categorias.Add(new Categoria(blancoN, blancoR, blancoS));
            /*
            Categorias.Add(new Categoria(identificadorN, identificadorR));
            Categorias.Add(new Categoria(asignacionN, asignacionR));
            Categorias.Add(new Categoria(realN, realR));
            Categorias.Add(new Categoria(enteroN, enteroR));
            Categorias.Add(new Categoria(rangoN, rangoR));
            Categorias.Add(new Categoria(blancoN, blancoR));
             */
            #endregion

            return Categorias;
        }

        public static string SeparacionTokensCategorias(List<Categoria> Categorias,string input)
        {
            string aux = EliminarEspacios(input);
            foreach (Categoria C in Categorias)
            {
                aux = C.separador.Invoke(aux);
            }
            return aux;
        }

        public static string EliminarEspacios(string input)
        {
            string[] inputR = Regex.Split(input, " ");
            List<string> r = new List<string>();
            foreach (string s in inputR)
            {
                r.Add(s);
            }
            return string.Join("", r);
        }

        public static string SeparadorGenerico(string input,Regex rex,string separador)
        {
            string[] inputR = Regex.Split(input, rex.ToString());
            List<string> r = new List<string>();
            for (int i = 0; i < inputR.Length; i++)
            {
                if (i != (inputR.Length - 1))
                {
                    r.Add(inputR[i]);
                    r.Add(" ");
                    r.Add(separador);
                    r.Add(" ");
                }
                else
                {
                    r.Add(inputR[i]);
                }
            }
            return string.Join("", r);
        }

        public static List<string> SeparacionTokens(string input)
        {
            List<string> TokensIniciales = new List<string>();
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
                    //TokensIniciales.Add(" "); //Comentar esta Linea si no se desea espacios en blanco para tokens finales
                    aux = "";
                }
            }
            TokensIniciales.Add(aux);
            #endregion 
            return TokensIniciales;
        }

        public static List<string> IdentificarTokens(List<Categoria> Categorias,List<string> TokensIniciales)
        {
            List<string> TokensFinales = new List<string>();
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
            return TokensFinales;
        }
    }
}
