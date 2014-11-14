using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorSintactico
{
    public class AnalizadorSintacticoC
    {

        public AnalizadorSintacticoC()
        {

        }
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
        public static List<List<string>> SeparadorTokens(List<string> input)
        {
            List<List<string>> Condicion = new List<List<string>>();
            List<string> Temp = new List<string>();
            bool CierraParentesis = false;
            for (int i = 0; i < input.Count; i++)
            {
                Temp.Add(input[i].ToString());
                //if (input[i].ToString() == "[13]") 
                //{
                //    if (input[i + 1].ToString() == "[15]")
                //    {

                //    }
                //    else
                //    {
                //        Condicion.Add(Temp);
                //        Temp = new List<string>();
                //        CierraParentesis = true;
                //    }
                //}
                if (input[i].ToString() == "[16]")
                {
                    Condicion.Add(Temp);
                    Temp = new List<string>();
                    CierraParentesis = true;
                }
                //else if (CierraParentesis == true)
                //{
                    if (/*input[i].ToString() == "[21]" || input[i].ToString() == "[22]" || input[i].ToString() == "[23]" || input[i].ToString() == "[24]" ||*/ input[i].ToString() == "[53]")
                    {
                        Condicion.Add(Temp);
                        Temp = new List<string>();
                    }
                //}
            }
            return Condicion;
        }
        public static Regla BuscarRegla(List<string> input, List<Regla> reglas)
        {
            Regla Aux = new Regla();
            int contador = 0;
            List<string> Temp = new List<string>();
            Regla TempR = new Regla();
            int contadorTem = 0;
            foreach (Regla r in reglas)
            {
                foreach (string s in input)
                {
                    Temp.Add(s);
                }
                foreach (string sr in r.Estructura)
                {
                    TempR.Estructura.Add(sr);
                }
                //Normalizacion
                if (input.Count != r.Estructura.Count)
                {
                    if ((input.Count - r.Estructura.Count) > 0)
                    {
                        for (int i = 0; i < (input.Count - r.Estructura.Count); i++)
                        {
                            TempR.Estructura.Add("-");
                        }
                        Temp.Add("-");
                    }
                    else
                    {
                        for (int i = 0; i < (r.Estructura.Count - input.Count); i++)
                        {
                            Temp.Add("-");
                        }
                        Temp.Add("-");
                    }
                }
                //Comparacion
                /*for (int i = 0; i < TempR.Estructura.Count; i++)
                {
                    if (TempR.Estructura[i] == Temp[i] && (Temp[i]!="-"&&TempR.Estructura[i]!="-"))
                    {
                        contadorTem++;
                    }
                }*/

                bool aux = false;
                for (int i = 0; i < TempR.Estructura.Count; i++)
                {
                    if ((Temp[i] != "-"))
                    {
                        for (int j = 0; j < TempR.Estructura.Count; j++)
                        {
                            if (Temp[i] == TempR.Estructura[j])
                                aux = true;
                        }
                    }
                    if(aux)
                    {
                        aux = false;
                            contadorTem++;
                    }
                }

                if(contadorTem>contador)
                {
                    Aux = r;
                    contador = contadorTem;
                }
                contadorTem = 0;
                Temp = new List<string>();
                TempR = new Regla();
            }
            return Aux;
        }
        public static string Comparacion(List<string> input, Regla regla)
        {
            string resultado = "\nCorrecto con coincidencia en "+regla.TipoR +" de tipo "+regla.TipoC;
            List<string> Temp = new List<string>();
            Regla TempR = new Regla();
            //Normalizacion
            foreach (string s in input)
            {
                Temp.Add(s);
            }
            foreach (string sr in regla.Estructura)
            {
                TempR.Estructura.Add(sr);
            }
            if (input.Count != regla.Estructura.Count)
            {
                if ((input.Count - regla.Estructura.Count) > 0)
                {
                    for (int i = 0; i < (input.Count - regla.Estructura.Count); i++)
                    {
                        TempR.Estructura.Add("-");
                    }
                }
                else
                {
                    for (int i = 0; i < (regla.Estructura.Count - input.Count); i++)
                    {
                        Temp.Add("-");
                    }
                }
            }
            for (int i = 0; i < regla.Estructura.Count; i++)
            {
                if (TempR.Estructura[i] != Temp[i])
                {
                    resultado = "\nError en Token: " + Temp[i] + "\nPosicion: " + i + "\nRegla: " + regla.TipoR + "\nTipo Regla: "+regla.TipoC;
                }
            }
            return resultado;

        }
        public static List<string> ListaRevision(List<string> input, List<Regla> reglas)
        {
            List<string> resultado = new List<string>();
            List<List<string>> Tokens = SeparadorTokens(input);
            foreach (List<string> ls in Tokens)
            {
                resultado.Add(Comparacion(ls, BuscarRegla(ls, reglas)));
            }
            return resultado;
        }
    }
}
