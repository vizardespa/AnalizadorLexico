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
                string[] inputR = Regex.Split(input, asignacionR.ToString());
                List<string> r = new List<string>();
                for (int i = 0; i < inputR.Length; i++)
                {
                    if (i != (inputR.Length - 1))
                    {
                        r.Add(inputR[i]);
                        r.Add(" ");
                        r.Add("=");
                        r.Add(" ");
                    }
                    else
                    {
                        r.Add(inputR[i]);
                    }
                }
                return string.Join("", r);
            };
            //Asignacion
            Func<string, string> asignacionS = (input) =>
            {
                return input;
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
                string[] inputR = Regex.Split(input, SumaR.ToString());
                List<string> r = new List<string>();
                for (int i = 0; i < inputR.Length; i++)
			    {
                    if(i!=(inputR.Length-1))
                    {
                        r.Add(inputR[i]);
                        r.Add(" ");
                        r.Add("+");
                        r.Add(" ");
                    }
                    else 
                    {
                        r.Add(inputR[i]);
                    }
			    }
                return string.Join("", r);
            };

            //Resta
            Func<string, string> RestaS = (input) =>
            {
                string[] inputR = Regex.Split(input, RestaR.ToString());
                List<string> r = new List<string>();
                for (int i = 0; i < inputR.Length; i++)
                {
                    if (i != (inputR.Length - 1))
                    {
                        r.Add(inputR[i]);
                        r.Add(" ");
                        r.Add("-");
                        r.Add(" ");
                    }
                    else
                    {
                        r.Add(inputR[i]);
                    }
                }
                return string.Join("", r);
            };

            //Multiplicacion
            Func<string, string> MultiplicacionS = (input) =>
            {
                string[] inputR = Regex.Split(input, MultiplicacionR.ToString());
                List<string> r = new List<string>();
                for (int i = 0; i < inputR.Length; i++)
                {
                    if (i != (inputR.Length - 1))
                    {
                        r.Add(inputR[i]);
                        r.Add(" ");
                        r.Add("*");
                        r.Add(" ");
                    }
                    else
                    {
                        r.Add(inputR[i]);
                    }
                }
                return string.Join("", r);
            };

            //Division
            Func<string, string> DivisionS = (input) =>
            {
                string[] inputR = Regex.Split(input, DivisionR.ToString());
                List<string> r = new List<string>();
                for (int i = 0; i < inputR.Length; i++)
                {
                    if (i != (inputR.Length - 1))
                    {
                        r.Add(inputR[i]);
                        r.Add(" ");
                        r.Add("/");
                        r.Add(" ");
                    }
                    else
                    {
                        r.Add(inputR[i]);
                    }
                }
                return string.Join("", r);
            };
#endregion
#region AgregacionCategorias
            Categorias.Add(new Categoria(SumaN,SumaR,SumaS));
            Categorias.Add(new Categoria(RestaN, RestaR, RestaS));
            Categorias.Add(new Categoria(DivisionN, DivisionR, DivisionS));
            Categorias.Add(new Categoria(MultiplicacionN, MultiplicacionR, MultiplicacionS));
            Categorias.Add(new Categoria(identificadorN, identificadorR, identificadorS));
            Categorias.Add(new Categoria(asignacionN, asignacionR, asignacionS));
            Categorias.Add(new Categoria(realN, realR, realS));
            Categorias.Add(new Categoria(enteroN, enteroR, enteroS));
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
#endregion
            while (true)
            {
                Console.WriteLine("Escribe una entrada...");
                string input = Console.ReadLine();
                List<string> TokensIniciales = new List<string>();
                List<string> TokensFinales = new List<string>();

                string s0 = Categorias[0].separador.Invoke(input);

                string auxiliar = input;
                foreach (Categoria C in Categorias)
                {
                    auxiliar = C.separador.Invoke(auxiliar);
                }
                input = auxiliar;
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
