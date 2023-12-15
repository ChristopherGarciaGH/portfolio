using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEnCSharp
{
    internal class Palindromo
    {
        private string s;

        public string S
        {
            get { return s; }
            set { s = value; }
        }

        public Palindromo(string s)
        {
            this.s = s;
        }

        public bool esPalindromo()

        {

            //Pasamos a minusculas
            string minusculas = s.ToLower();

            //Quitamos los espacios
            string sinEspacios = "";
            int i = 0;


            while (i < minusculas.Length)
            {
                if (minusculas[i] != ' ')
                {
                    sinEspacios += minusculas[i];
                }
                i++;
            }

            //Console.WriteLine(sinEspacios);

            //Comprobamos si es palindromo invirtiendo la variable sinEspacios
            int j = sinEspacios.Length - 1;
            String inversa = "";


            while (j >= 0)
            {
                inversa += sinEspacios[j];
                j--;
            }

            //Console.WriteLine("El string invertido es " + inversa);


            //Comprobamos si es un palindromo

            if (sinEspacios == inversa)
            {
                Console.WriteLine("Es palindromo");
                return true;
            }
            else
            {
                Console.WriteLine("No es palindromo");
                return false;
            }


        }
    }
}
