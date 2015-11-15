using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forca
{
    class Tudo
    {
        //LOGIN
        public const string login = "admin";
        public const string senha = "admin";

        //PALAVRA
        public static string palavra = "INCONSTITUCIONALMENTE";
        public static string dica1 = "";
        public static string dica2 = "";
        public static string dica3 = "";

        //LETRAS
        public static string letras = " ";

        //CHANCES
        public static int chances = 5;

        public static string[] tranformarStringArray(string palavra)
        {
            char delimitadores = ' ';
            string[] arrayParalvras = palavra.Split(delimitadores);

            return arrayParalvras;
        }

        public static string[] conjuntoEmTracos()
        {
            string[] palavraConjunto = tranformarStringArray(palavra);

            for (int i=0;i < palavraConjunto.Length;i++)
            {
                int numeroTracos = palavraConjunto[i].Length;
                palavraConjunto[i] = "";

                for(int j = 0; j < numeroTracos;j++)
                {
                    palavraConjunto[i] = palavraConjunto[i] +  "-";
                }
            }
            
            return palavraConjunto;
        }
    }
}
