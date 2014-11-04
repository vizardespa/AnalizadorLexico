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
                List<string> TokensFinalesN = IdentificarTokensNombre(Categorias,TokensIniciales);
                List<string> TokensFinalesC = IdentificarTokensClave(Categorias, TokensIniciales);

                Console.WriteLine("Salida en Tokens por Nombre...");
                TokensFinalesN.ForEach(x => { Console.Write(x); });
                Console.WriteLine();
                Console.WriteLine("Salida en Tokens por Clave...");
                TokensFinalesC.ForEach(x => { Console.Write(x); });
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
            Regex EnteroR = new Regex(@"^[0-9]+$");
            string EnteroN = "[Entero]";
            string EnteroC = "[1]";

            //Real
            Regex RealR = new Regex(@"^[0-9]+\.[0-9]+$");
            string RealN = "[Real]";
            string RealC = "[2]";

            //Identificador
            Regex IdentificadorR = new Regex(@"^[a-zA-Z][a-zA-Z0-9]*");
            string IdentificadorN = "[Identificador]";
            string IdentificadorC = "[3]";

            //Asignacion
            Regex AsignacionR = new Regex(@"=");
            string AsignacionN = "[Asignacion]";
            string AsignacionC = "[4]";

            //Rango
            Regex RangoR = new Regex(@"\.\.");
            string RangoN = "[Rango]";
            string RangoC = "[5]";

            //Blanco
            Regex BlancoR = new Regex(@"[\s]+");
            string BlancoN = "[Blanco]";
            string BlancoC = "[0]";

            //Letras
            Regex LetrasR = new Regex(@"[a-zA-Z]+");
            string LetrasN = "[Letra]";
            string LetrasC = "[Letra]";

            //Simbolos
            Regex SimbolosR = new Regex(@"[+\-*/=!.]+");
            string SimbolosN = "[Simbolo]";
            string SimbolosC = "[Simbolo]";

            //Suma
            Regex SumaR = new Regex(@"\+");
            string SumaN = "[Suma]";
            string SumaC = "[21]";

            //Resta
            Regex RestaR = new Regex(@"\-");
            string RestaN = "[Resta]";
            string RestaC = "[22]";

            //Division
            Regex DivisionR = new Regex(@"/");
            string DivisionN = "[Division]";
            string DivisionC = "[24]";

            //Multiplicacion
            Regex MultiplicacionR = new Regex(@"\*");
            string MultiplicacionN = "[Multiplicacion]";
            string MultiplicacionC = "[23]";

            //EOF
            Regex EOFR = new Regex(@"\Z");
            string EOFN = "[EOF]";
            string EOFC = "[99]";

            //if
            Regex IfR = new Regex(@"^if$");
            string IfN = "[if]";
            string IfC = "[6]";

            //else
            Regex ElseR = new Regex(@"^else$");
            string ElseN = "[else]";
            string ElseC = "[7]";

            //else if
            Regex ElseifR = new Regex(@"^else if$");
            string ElseifN = "[else if]";
            string ElseifC = "[8]";

            //while
            Regex WhileR = new Regex(@"^while$");
            string WhileN = "[while]";
            string WhileC = "[9]";

            //for
            Regex ForR = new Regex(@"^for$");
            string ForN = "[for]";
            string ForC = "[10]";

            //foreach
            Regex ForeachR = new Regex(@"^foreach$");
            string ForeachN = "[foreach]";
            string ForeachC = "[11]";

            //AbreParetesis
            Regex AbreParetesisR = new Regex(@"\(");
            string AbreParetesisN = "[AbreParetesis]";
            string AbreParetesisC = "[12]";

            //CierraParentesis
            Regex CierraParentesisR = new Regex(@"\)");
            string CierraParentesisN = "[CierraParentesis]";
            string CierraParentesisC = "[13]";

            //AbreCorchete
            Regex AbreCorcheteR = new Regex(@"\[");
            string AbreCorcheteN = "[AbreCorchete]";
            string AbreCorcheteC = "[25]";

            //CierraCorchete
            Regex CierraCorcheteR = new Regex(@"\]");
            string CierraCorcheteN = "[CierraCorchete]";
            string CierraCorcheteC = "[26]";

            //Magic
            Regex MagicR = new Regex(@"^magic$");
            string MagicN = "[Magic]";
            string MagicC = "[50]";

            //AbreLlave
            Regex AbreLlaveR = new Regex(@"{");
            string AbreLlaveN = "[AbreLlave]";
            string AbreLlaveC = "[15]";

            //CierraLlave
            Regex CierraLlaveR = new Regex(@"}");
            string CierraLlaveN = "[CierraLlave]";
            string CierraLlaveC = "[16]";

            //MayorQue
            Regex MayorQueR = new Regex(@">");
            string MayorQueN = "[MayorQue]";
            string MayorQueC = "[17]";

            //MenorQue
            Regex MenorQueR = new Regex(@"<");
            string MenorQueN = "[MenorQue]";
            string MenorQueC = "[18]";

            //MayorIgualQue
            Regex MayorIgualQueR = new Regex(@">=");
            string MayorIgualQueN = "[MayorIgualQue]";
            string MayorIgualQueC = "[19]";

            //MenorIgualQue
            Regex MenorIgualQueR = new Regex(@"<=");
            string MenorIgualQueN = "[MenorIgualQue]";
            string MenorIgualQueC = "[20]";

            //WhatIsLove
            Regex WhatIsLoveR = new Regex(@"^WhatIsLove$");
            string WhatIsLoveN = "[WhatIsLove]";
            string WhatIsLoveC = "[51]";

            //BabyDonthHurtMe
            Regex BabyDonthHurtMeR = new Regex(@"^BabyDonthHurtMe$");
            string BabyDonthHurtMeN = "[BabyDonthHurtMe]";
            string BabyDonthHurtMeC = "[52]";

            //PuntoComa
            Regex PuntoComaR = new Regex(@";");
            string PuntoComaN = "[PuntoComa]";
            string PuntoComaC = "[53]";

            //int
            Regex IntR = new Regex(@"^int$");
            string IntN = "[int]";
            string IntC = "[27]";

            //string
            Regex StringR = new Regex(@"^string$");
            string StringN = "[string]";
            string StringC = "[28]";

            //bool
            Regex BoolR = new Regex(@"^bool$");
            string BoolN = "[bool]";
            string BoolC = "[29]";

            //double
            Regex DoubleR = new Regex(@"^double$");
            string DoubleN = "[double]";
            string DoubleC = "[30]";

            //char
            Regex CharR = new Regex(@"^char$");
            string CharN = "[char]";
            string CharC = "[31]";

            //var
            Regex VarR = new Regex(@"^var$");
            string VarN = "[var]";
            string VarC = "[32]";

            //List
            Regex ListR = new Regex(@"^List$");
            string ListN = "[List]";
            string ListC = "[33]";

            //in
            Regex InR = new Regex(@"^in$");
            string InN = "[in]";
            string InC = "[34]";

            //Coma
            Regex ComaR = new Regex(@",");
            string ComaN = "[coma]";
            string ComaC = "[54]";

            //ComillaSimple
            Regex ComillaSimpleR = new Regex(@"\'");
            string ComillaSimpleN = "[ComillaSimple]";
            string ComillaSimpleC = "[55]";

            //ComillaDoble
            Regex ComillaDobleR = new Regex("\"");
            string ComillaDobleN = "[ComillaDoble]";
            string ComillaDobleC = "[54]";

            #endregion

            #region Funciones
            //Funciones...

            //Entero
            Func<string, string> EnteroS = (input) =>
            {
                return input;
            };

            //Real
            Func<string, string> RealS = (input) =>
            {
                return input;
            };

            //Identificador
            Func<string, string> IdentificadorS = (input) =>
            {
                //return SeparadorGenerico(input, identificadorR, "MetodologiaPendiente");
                return input;
            };

            //Asignacion
            Func<string, string> AsignacionS = (input) =>
            {
                return SeparadorGenerico(input, AsignacionR, "=");
            };

            //Rango
            Func<string, string> RangoS = (input) =>
            {
                return input;
            };

            //Blanco
            Func<string, string> BlancoS = (input) =>
            {
                string[] inputR = Regex.Split(input, BlancoR.ToString());
                List<string> r = new List<string>();
                for (int i = 0; i < inputR.Length; i++)
                {
                    if (i != (inputR.Length - 1))
                    {
                        r.Add(inputR[i]);
                        r.Add(" ");
                    }
                    else
                    {
                        r.Add(inputR[i]);
                    }
                }
                return string.Join("", r);
                //return SeparadorGenerico(input, BlancoR, " ");
                //return input;
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

            //PuntoComa
            Func<string, string> PuntoComaS = (input) =>
            {
                return SeparadorGenerico(input, PuntoComaR, ";");
            };

            //Coma
            Func<string, string> ComaS = (input) =>
            {
                return SeparadorGenerico(input, ComaR, ",");
            };

            //ComillaSimple
            Func<string, string> ComillaSimpleS = (input) =>
            {
                return SeparadorGenerico(input, ComillaSimpleR, "'");
            };

            //ComillaDoble
            Func<string, string> ComillaDobleS = (input) =>
            {
                return SeparadorGenerico(input, ComillaDobleR, "\"");
            };

            //EOF
            Func<string, string> EOFS = (input) =>
            {
                return input;
            };

            //if
            Func<string, string> IfS = (input) =>
            {
                return input;
            };

            //else
            Func<string, string> ElseS = (input) =>
            {
                return input;
            };

            //else if
            Func<string, string> ElseifS = (input) =>
            {
                return input;
            };

            //while
            Func<string, string> WhileS = (input) =>
            {
                return input;
            };

            //for
            Func<string, string> ForS = (input) =>
            {
                return input;
            };

            //foreach
            Func<string, string> ForeachS = (input) =>
            {
                return input;
            };

            //AbreParetesis
            Func<string, string> AbreParetesisS = (input) =>
            {
                return SeparadorGenerico(input, AbreParetesisR, "(");
            };

            //CierraParentesis
            Func<string, string> CierraParentesisS = (input) =>
            {
                return SeparadorGenerico(input, CierraParentesisR, ")");
            };

            //AbreCorchete
            Func<string, string> AbreCorcheteS = (input) =>
            {
                return SeparadorGenerico(input, AbreCorcheteR, "[");
            };

            //CierraCorchete
            Func<string, string> CierraCorcheteS = (input) =>
            {
                return SeparadorGenerico(input, CierraCorcheteR, "]");
            };

            //Magic
            Func<string, string> MagicS = (input) =>
            {
                return input;
            };

            //AbreLlave
            Func<string, string> AbreLlaveS = (input) =>
            {
                return SeparadorGenerico(input, AbreLlaveR, "{");
            };

            //CierraLlave
            Func<string, string> CierraLlaveS = (input) =>
            {
                return SeparadorGenerico(input, CierraLlaveR, "}");
            };

            //MayorQue
            Func<string, string> MayorQueS = (input) =>
            {
                return SeparadorGenerico(input, MayorQueR, ">");
            };

            //MenorQue
            Func<string, string> MenorQueS = (input) =>
            {
                return SeparadorGenerico(input, MenorQueR, "<");
            };

            //MayorIgualQue
            Func<string, string> MayorIgualQueS = (input) =>
            {
                return SeparadorGenerico(input, MayorIgualQueR, ">=");
            };

            //MenorIgualQue
            Func<string, string> MenorIgualQueS = (input) =>
            {
                return SeparadorGenerico(input, MenorIgualQueR, "<=");
            };

            //WhatIsLove
            Func<string, string> WhatIsLoveS = (input) =>
            {
                return input;
            };

            //BabyDonthHurtMe
            Func<string, string> BabyDonthHurtMeS = (input) =>
            {
                return input;
            };

            //int
            Func<string, string> IntS = (input) =>
            {
                return input;
            };

            //string
            Func<string, string> StringS = (input) =>
            {
                return input;
            };

            //bool
            Func<string, string> BoolS = (input) =>
            {
                return input;
            };

            //Double
            Func<string, string> DoubleS = (input) =>
            {
                return input;
            };

            //Char
            Func<string, string> CharS = (input) =>
            {
                return input;
            };

            //List
            Func<string, string> ListS = (input) =>
            {
                return input;
            };

            //Var
            Func<string, string> VarS = (input) =>
            {
                return input;
            };

            //in
            Func<string, string> InS = (input) =>
            {
                return input;
            };

            #endregion

            #region AgregacionCategorias
            Categorias.Add(new Categoria(BlancoN, BlancoC, BlancoR, BlancoS));
            Categorias.Add(new Categoria(SumaN,SumaC, SumaR, SumaS));
            Categorias.Add(new Categoria(RestaN,RestaC, RestaR, RestaS));
            Categorias.Add(new Categoria(DivisionN,DivisionC, DivisionR, DivisionS));
            Categorias.Add(new Categoria(MultiplicacionN,MultiplicacionC, MultiplicacionR, MultiplicacionS));
            Categorias.Add(new Categoria(PuntoComaN, PuntoComaC, PuntoComaR, PuntoComaS));
            Categorias.Add(new Categoria(ComaN, ComaC, ComaR, ComaS));
            Categorias.Add(new Categoria(ComillaSimpleN, ComillaSimpleC, ComillaSimpleR, ComillaSimpleS));
            Categorias.Add(new Categoria(ComillaDobleN, ComillaDobleC, ComillaDobleR, ComillaDobleS));
            Categorias.Add(new Categoria(MayorIgualQueN, MayorIgualQueC, MayorIgualQueR, MayorIgualQueS));
            Categorias.Add(new Categoria(MenorIgualQueN, MenorIgualQueC, MenorIgualQueR, MenorIgualQueS));
            Categorias.Add(new Categoria(AsignacionN, AsignacionC, AsignacionR, AsignacionS));
            Categorias.Add(new Categoria(AbreParetesisN, AbreParetesisC, AbreParetesisR, AbreParetesisS));
            Categorias.Add(new Categoria(CierraParentesisN, CierraParentesisC, CierraParentesisR, CierraParentesisS));
            Categorias.Add(new Categoria(AbreCorcheteN, AbreCorcheteC, AbreCorcheteR, AbreCorcheteS));
            Categorias.Add(new Categoria(CierraCorcheteN, CierraCorcheteC, CierraCorcheteR, CierraCorcheteS));
            Categorias.Add(new Categoria(AbreLlaveN, AbreLlaveC, AbreLlaveR, AbreLlaveS));
            Categorias.Add(new Categoria(CierraLlaveN, CierraLlaveC, CierraLlaveR, CierraLlaveS));
            Categorias.Add(new Categoria(MayorQueN, MayorQueC, MayorQueR, MayorQueS));
            Categorias.Add(new Categoria(MenorQueN, MenorQueC, MenorQueR, MenorQueS));
            //Categorias.Add(new Categoria(EOFN, EOFC, EOFR, EOFS));
            Categorias.Add(new Categoria(RangoN,RangoC, RangoR, RangoS));
            Categorias.Add(new Categoria(WhatIsLoveN, WhatIsLoveC, WhatIsLoveR, WhatIsLoveS));
            Categorias.Add(new Categoria(BabyDonthHurtMeN, BabyDonthHurtMeC, BabyDonthHurtMeR, BabyDonthHurtMeS));
            Categorias.Add(new Categoria(IfN, IfC, IfR, IfS));
            Categorias.Add(new Categoria(ElseN, ElseC, ElseR, ElseS));
            Categorias.Add(new Categoria(ElseifN, ElseifC, ElseifR, ElseifS));
            Categorias.Add(new Categoria(WhileN, WhileC, WhileR, WhileS));
            Categorias.Add(new Categoria(ForeachN, ForeachC, ForeachR, ForeachS));
            Categorias.Add(new Categoria(ForN, ForC, ForR, ForS));
            Categorias.Add(new Categoria(MagicN, MagicC, MagicR, MagicS));
            Categorias.Add(new Categoria(IntN, IntC, IntR, IntS));
            Categorias.Add(new Categoria(StringN, StringC, StringR, StringS));
            Categorias.Add(new Categoria(BoolN, BoolC, BoolR, BoolS));
            Categorias.Add(new Categoria(DoubleN, DoubleC, DoubleR, DoubleS));
            Categorias.Add(new Categoria(CharN, CharC, CharR, CharS));
            Categorias.Add(new Categoria(VarN, VarC, VarR, VarS));
            Categorias.Add(new Categoria(ListN, ListC, ListR, ListS));
            Categorias.Add(new Categoria(InN, InC, InR, InS));
            Categorias.Add(new Categoria(IdentificadorN, IdentificadorC, IdentificadorR, IdentificadorS));
            Categorias.Add(new Categoria(RealN, RealC, RealR, RealS));
            Categorias.Add(new Categoria(EnteroN, EnteroC, EnteroR, EnteroS));
            #endregion

            return Categorias;
        }

        public static string SeparacionTokensCategorias(List<Categoria> Categorias,string input)
        {
            //string aux = EliminarEspacios(input);
            string aux = input;
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
                    if (aux!="")
                    TokensIniciales.Add(aux);
                    //TokensIniciales.Add(" "); //Comentar esta Linea si no se desea espacios en blanco para tokens finales
                    aux = "";
                }
            }
            if (aux != "")
            TokensIniciales.Add(aux);
            #endregion 
            return TokensIniciales;
        }

        public static List<string> IdentificarTokensNombre(List<Categoria> Categorias,List<string> TokensIniciales)
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

        public static List<string> IdentificarTokensClave(List<Categoria> Categorias, List<string> TokensIniciales)
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
                        TokensFinales.Add(C.clave);
                        r = true;
                        break;
                    }
                }
                if (!r)
                {
                    TokensFinales.Add("[404]");
                }
            }
            #endregion
            return TokensFinales;
        }
    }
}
