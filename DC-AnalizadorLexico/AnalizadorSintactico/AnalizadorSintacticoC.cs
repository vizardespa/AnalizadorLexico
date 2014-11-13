using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorSintactico
{
    public class AnalizadorSintacticoC
    {


        public static List<Regla> CargarReglas()
        {
            List<Regla> Reglas = new List<Regla>();
            #region EstructurasRelas
            //Estruturas...
            //Entero
            List<string> EnteroE = new List<string>();
            EnteroE.Add("[1]");

            //Real
            List<string> RealE = new List<string>();
            RealE.Add("[2]");

            //Identificador
            List<string> IdentificadorE = new List<string>();
            IdentificadorE.Add("[3]");

            //OperadorSuma
            List<string> OperadorSumaE = new List<string>();
            OperadorSumaE.Add("[21]");

            //OperadorResta
            List<string> OperadorRestaE = new List<string>();
            OperadorRestaE.Add("[22]");

            //OperadorMultiplicacion
            List<string> OperadorMultiplicacionE = new List<string>();
            OperadorMultiplicacionE.Add("[23]");

            //OperadorDivision
            List<string> OperadorDivisionE = new List<string>();
            OperadorDivisionE.Add("[24]");

            //SimboloCondicionalMayorQue
            List<string> SimboloCondicionalMayorQueE = new List<string>();
            SimboloCondicionalMayorQueE.Add("[17]");

            //SimboloCondicionalMenorQue
            List<string> SimboloCondicionalMenorQueE = new List<string>();
            SimboloCondicionalMenorQueE.Add("[18]");

            //SimboloCondicionalIgual
            List<string> SimboloCondicionalIgualE = new List<string>();
            SimboloCondicionalIgualE.Add("[4]");
            SimboloCondicionalIgualE.Add("[4]");

            //SimboloCondicionalMayorIgualQue
            List<string> SimboloCondicionalMayorIgualQueE = new List<string>();
            SimboloCondicionalMayorIgualQueE.Add("[17]");
            SimboloCondicionalMayorIgualQueE.Add("[4]");

            //SimboloCondicionalMenorIgualQue
            List<string> SimboloCondicionalMenorIgualQueE = new List<string>();
            SimboloCondicionalMenorIgualQueE.Add("[18]");
            SimboloCondicionalMenorIgualQueE.Add("[4]");

            //PalabraReservadaInt
            List<string> PalabraReservadaIntE = new List<string>();
            PalabraReservadaIntE.Add("[27]");

            //PalabraReservadaString
            List<string> PalabraReservadaStringE = new List<string>();
            PalabraReservadaStringE.Add("[28]");

            //PalabraReservadaBool
            List<string> PalabraReservadaBoolE = new List<string>();
            PalabraReservadaBoolE.Add("[29]");

            //PalabraReservadaDouble
            List<string> PalabraReservadaDoubleE = new List<string>();
            PalabraReservadaDoubleE.Add("[30]");

            //PalabraReservadaChar
            List<string> PalabraReservadaCharE = new List<string>();
            PalabraReservadaCharE.Add("[31]");

            //PalabraReservadaVar
            List<string> PalabraReservadaVarE = new List<string>();
            PalabraReservadaVarE.Add("[32]");

            //PalabraReservadaList
            List<string> PalabraReservadaListE = new List<string>();
            PalabraReservadaListE.Add("[33]");
            PalabraReservadaListE.Add("[18]");
            PalabraReservadaListE.Add("PalabraReservada");
            PalabraReservadaListE.Add("[17]");

            //Operacion
            List<string> OperacionE = new List<string>();
            OperacionE.Add("Expresion");
            OperacionE.Add("Operador");
            OperacionE.Add("Expresion");

            //Condicion
            List<string> CondicionE = new List<string>();
            CondicionE.Add("Expresion");
            CondicionE.Add("SimboloCondicional");
            CondicionE.Add("Expresion");

            //ComparacionIf
            List<string> ComparacionIfE = new List<string>();
            ComparacionIfE.Add("[6]");
            ComparacionIfE.Add("[12]");
            ComparacionIfE.Add("Condicion");
            ComparacionIfE.Add("[13]");
            ComparacionIfE.Add("[15]");
            ComparacionIfE.Add("Sentencia");
            ComparacionIfE.Add("[16]");

            //ComparacionIfElse
            List<string> ComparacionIfElseE = new List<string>();
            ComparacionIfElseE.Add("[6]");
            ComparacionIfElseE.Add("[12]");
            ComparacionIfElseE.Add("Condicion");
            ComparacionIfElseE.Add("[13]");
            ComparacionIfElseE.Add("[15]");
            ComparacionIfElseE.Add("Sentencia");
            ComparacionIfElseE.Add("[16]");
            ComparacionIfElseE.Add("[7]");
            ComparacionIfElseE.Add("[15]");
            ComparacionIfElseE.Add("Sentencia");
            ComparacionIfElseE.Add("[16]");

            //ComparacionIfElseIf
            List<string> ComparacionIfElseIfE = new List<string>();
            ComparacionIfElseIfE.Add("[6]");
            ComparacionIfElseIfE.Add("[12]");
            ComparacionIfElseIfE.Add("Condicion");
            ComparacionIfElseIfE.Add("[13]");
            ComparacionIfElseIfE.Add("[15]");
            ComparacionIfElseIfE.Add("Sentencia");
            ComparacionIfElseIfE.Add("[16]");
            ComparacionIfElseIfE.Add("[7]");
            ComparacionIfElseIfE.Add("[6]");
            ComparacionIfElseIfE.Add("[12]");
            ComparacionIfElseIfE.Add("Condicion");
            ComparacionIfElseIfE.Add("[13]");
            ComparacionIfElseIfE.Add("[15]");
            ComparacionIfElseIfE.Add("Sentencia");
            ComparacionIfElseIfE.Add("[16]");

            //Declaracion
            List<string> DeclaracionE = new List<string>();
            DeclaracionE.Add("PalabraReservada");
            DeclaracionE.Add("[3]");
            DeclaracionE.Add("[53]");

            //AsignacionSimple
            List<string> AsignacionSimpleE = new List<string>();
            AsignacionSimpleE.Add("[3]");
            AsignacionSimpleE.Add("[4]");
            AsignacionSimpleE.Add("Expresion");
            AsignacionSimpleE.Add("[53]");

            //DeclaracionAsignacionInt
            List<string> DeclaracionAsignacionIntE = new List<string>();
            DeclaracionAsignacionIntE.Add("[27]");
            DeclaracionAsignacionIntE.Add("[3]");
            DeclaracionAsignacionIntE.Add("[4]");
            DeclaracionAsignacionIntE.Add("[1]");
            DeclaracionAsignacionIntE.Add("[53]");

            //DeclaracionAsignacionString
            List<string> DeclaracionAsignacionStringE = new List<string>();
            DeclaracionAsignacionStringE.Add("[28]");
            DeclaracionAsignacionStringE.Add("[3]");
            DeclaracionAsignacionStringE.Add("[4]");
            DeclaracionAsignacionStringE.Add("[56]");
            DeclaracionAsignacionStringE.Add("[70]");
            DeclaracionAsignacionStringE.Add("[56]");
            DeclaracionAsignacionStringE.Add("[53]");

            //DeclaracionAsignacionBoolMagic
            List<string> DeclaracionAsignacionBoolMagicE = new List<string>();
            DeclaracionAsignacionBoolMagicE.Add("[29]");
            DeclaracionAsignacionBoolMagicE.Add("[3]");
            DeclaracionAsignacionBoolMagicE.Add("[4]");
            DeclaracionAsignacionBoolMagicE.Add("[50]");
            DeclaracionAsignacionBoolMagicE.Add("[53]");

            //DeclaracionAsignacionBoolScience
            List<string> DeclaracionAsignacionBoolScienceE = new List<string>();
            DeclaracionAsignacionBoolScienceE.Add("[29]");
            DeclaracionAsignacionBoolScienceE.Add("[3]");
            DeclaracionAsignacionBoolScienceE.Add("[4]");
            DeclaracionAsignacionBoolScienceE.Add("[58]");
            DeclaracionAsignacionBoolScienceE.Add("[53]");

            //DeclaracionAsignacionDouble
            List<string> DeclaracionAsignacionDoubleE = new List<string>();
            DeclaracionAsignacionDoubleE.Add("[30]");
            DeclaracionAsignacionDoubleE.Add("[3]");
            DeclaracionAsignacionDoubleE.Add("[4]");
            DeclaracionAsignacionDoubleE.Add("[2]");
            DeclaracionAsignacionDoubleE.Add("[53]");

            //DeclaracionAsignacionChar
            List<string> DeclaracionAsignacionCharE = new List<string>();
            DeclaracionAsignacionCharE.Add("[31]");
            DeclaracionAsignacionCharE.Add("[3]");
            DeclaracionAsignacionCharE.Add("[4]");
            DeclaracionAsignacionCharE.Add("[71]");
            DeclaracionAsignacionCharE.Add("[53]");

            //DeclaracionAsignacionVar
            List<string> DeclaracionAsignacionVarE = new List<string>();
            DeclaracionAsignacionVarE.Add("[32]");
            DeclaracionAsignacionVarE.Add("[3]");
            DeclaracionAsignacionVarE.Add("[4]");
            DeclaracionAsignacionVarE.Add("Expresion");
            DeclaracionAsignacionVarE.Add("[53]");

            //DeclaracionAsignacionList
            List<string> DeclaracionAsignacionListE = new List<string>();
            DeclaracionAsignacionListE.Add("[33]");
            DeclaracionAsignacionListE.Add("[18]");
            DeclaracionAsignacionListE.Add("PalabraReservada");
            DeclaracionAsignacionListE.Add("[17]");
            DeclaracionAsignacionListE.Add("[3]");
            DeclaracionAsignacionListE.Add("[4]");
            DeclaracionAsignacionListE.Add("[33]");
            DeclaracionAsignacionListE.Add("[18]");
            DeclaracionAsignacionListE.Add("PalabraReservada");
            DeclaracionAsignacionListE.Add("[17]");
            DeclaracionAsignacionListE.Add("[53]");

            //CicloWhile
            List<string> CicloWhileE = new List<string>();
            CicloWhileE.Add("[9]");
            CicloWhileE.Add("[12]");
            CicloWhileE.Add("[Condicion]");
            CicloWhileE.Add("[13]");
            CicloWhileE.Add("[15]");
            CicloWhileE.Add("Sentencia");
            CicloWhileE.Add("[16]");

            //CicloFor
            List<string> CicloForE = new List<string>();
            CicloForE.Add("[10]");
            CicloForE.Add("[12]");
            CicloForE.Add("DeclaracionAsignacionInt");
            CicloForE.Add("Condicion");
            CicloForE.Add("[53]");
            CicloForE.Add("[3]");
            CicloForE.Add("[21]");
            CicloForE.Add("[21]");
            CicloForE.Add("[13]");
            CicloForE.Add("[15]");
            CicloForE.Add("Sentencia");
            CicloForE.Add("[16]");

            //CicloForEach
            List<string> CicloForEachE = new List<string>();
            CicloForEachE.Add("[11]");
            CicloForEachE.Add("[12]");
            CicloForEachE.Add("[3]");
            CicloForEachE.Add("[34]");
            CicloForEachE.Add("[3]");
            CicloForEachE.Add("[13]");
            CicloForEachE.Add("[15]");
            CicloForEachE.Add("Sentencia");
            CicloForEachE.Add("[16]");

            //SentenciaCiclo
            List<string> SentenciaCicloE = new List<string>();
            SentenciaCicloE.Add("Ciclo");

            //SentenciaAsignacion
            List<string> SentenciaAsignacionE = new List<string>();
            SentenciaAsignacionE.Add("Asignacion");

            //SentenciaDeclaracion
            List<string> SentenciaDeclaracionE = new List<string>();
            SentenciaDeclaracionE.Add("Declaracion");

            //SentenciaAsignacionDeclaracion
            List<string> SentenciaAsignacionDeclaracionE = new List<string>();
            SentenciaAsignacionDeclaracionE.Add("AsignacionDeclaracion");

            //SentenciaComparacion
            List<string> SentenciaComparacionE = new List<string>();
            SentenciaComparacionE.Add("Comparacion");

            #endregion

            #region AgregacionReglas
            Reglas.Add(new Regla("Entero", "Expresion", EnteroE));
            Reglas.Add(new Regla("Real", "Expresion", RealE));
            Reglas.Add(new Regla("Identificador", "Expresion", IdentificadorE));
            Reglas.Add(new Regla("Suma", "Operador", OperadorSumaE));
            Reglas.Add(new Regla("Resta", "Operador", OperadorRestaE));
            Reglas.Add(new Regla("Multiplicacion", "Operador", OperadorMultiplicacionE));
            Reglas.Add(new Regla("Division", "Operador", OperadorDivisionE));
            Reglas.Add(new Regla("MayorQue", "SimboloCondicional", SimboloCondicionalMayorQueE));
            Reglas.Add(new Regla("MenorQue", "SimboloCondicional", SimboloCondicionalMenorQueE));
            Reglas.Add(new Regla("Igual", "SimboloCondicional", SimboloCondicionalIgualE));
            Reglas.Add(new Regla("MayorIgualQue", "SimboloCondicional", SimboloCondicionalMayorIgualQueE));
            Reglas.Add(new Regla("MenorIgualQue", "SimboloCondicional", SimboloCondicionalMenorIgualQueE));
            Reglas.Add(new Regla("PalabraReservadaInt", "PalabraReservada", PalabraReservadaIntE));
            Reglas.Add(new Regla("PalabraReservadaString", "PalabraReservada", PalabraReservadaStringE));
            Reglas.Add(new Regla("PalabraReservadaBool", "PalabraReservada", PalabraReservadaBoolE));
            Reglas.Add(new Regla("PalabraReservadaDouble", "PalabraReservada", PalabraReservadaDoubleE));
            Reglas.Add(new Regla("PalabraReservadaChar", "PalabraReservada", PalabraReservadaCharE));
            Reglas.Add(new Regla("PalabraReservadaVar", "PalabraReservada", PalabraReservadaVarE));
            Reglas.Add(new Regla("PalabraReservadaList", "PalabraReservada", PalabraReservadaVarE));
            Reglas.Add(new Regla("Operacion", "Expresion", OperacionE));
            Reglas.Add(new Regla("Condicion", "Condicion", CondicionE));
            Reglas.Add(new Regla("ComparacionIf", "Comparacion", ComparacionIfE));
            Reglas.Add(new Regla("ComparacionIfElse", "Comparacion", ComparacionIfElseE));
            Reglas.Add(new Regla("ComparacionIfElseIf", "Comparacion", ComparacionIfElseIfE));
            Reglas.Add(new Regla("Declaracion", "Declaracion", DeclaracionE));
            Reglas.Add(new Regla("AsignacionSimple", "Asignacion", AsignacionSimpleE));
            Reglas.Add(new Regla("DeclaracionAsignacionInt", "Declaracion", DeclaracionAsignacionIntE));
            Reglas.Add(new Regla("DeclaracionAsignacionString", "Declaracion", DeclaracionAsignacionStringE));
            Reglas.Add(new Regla("DeclaracionAsignacionBoolMagic", "Declaracion", DeclaracionAsignacionBoolMagicE));
            Reglas.Add(new Regla("DeclaracionAsignacionBoolScience", "Declaracion", DeclaracionAsignacionBoolScienceE));
            Reglas.Add(new Regla("DeclaracionAsignacionDouble", "Declaracion", DeclaracionAsignacionDoubleE));
            Reglas.Add(new Regla("DeclaracionAsignacionChar", "Declaracion", DeclaracionAsignacionCharE));
            Reglas.Add(new Regla("DeclaracionAsignacionList", "Declaracion", DeclaracionAsignacionListE));
            Reglas.Add(new Regla("CicloWhile", "Ciclo", CicloWhileE));
            Reglas.Add(new Regla("CicloFor", "Ciclo", CicloForE));
            Reglas.Add(new Regla("CicloForEach", "Ciclo", CicloForEachE));
            Reglas.Add(new Regla("SentenciaCiclo", "Sentencia", SentenciaCicloE));
            Reglas.Add(new Regla("SentenciaAsignacion", "Sentencia", SentenciaAsignacionE));
            Reglas.Add(new Regla("SentenciaDeclaracion", "Sentencia", SentenciaDeclaracionE));
            Reglas.Add(new Regla("SentenciaAsignacionDeclaracion", "Sentencia", SentenciaAsignacionDeclaracionE));
            Reglas.Add(new Regla("SentenciaComparacion", "Sentencia", SentenciaComparacionE));

            #endregion

            return Reglas;
        }

        public static string SeparacionTokensReglas(List<Regla> Reglas, string input)
        {
            //string aux = EliminarEspacios(input);
            string aux = input;
            foreach (Regla C in Reglas)
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

        public static string SeparadorGenerico(string input, Regex rex, string separador)
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
                    if (aux != "")
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

        public static List<string> IdentificarTokensNombre(List<Regla> Reglas, List<string> TokensIniciales)
        {
            List<string> TokensFinales = new List<string>();
            #region IdentificacionTokens
            foreach (string s in TokensIniciales)
            {
                bool r = false;
                foreach (Regla C in Reglas)
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

        public static List<string> IdentificarTokensClave(List<Regla> Reglas, List<string> TokensIniciales)
        {
            List<string> TokensFinales = new List<string>();
            #region IdentificacionTokens
            foreach (string s in TokensIniciales)
            {
                bool r = false;
                foreach (Regla C in Reglas)
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
