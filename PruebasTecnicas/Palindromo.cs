using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEnCSharp
{
    public class ResultadoPalindromo()
    {
        public string FraseInversa { get; set; } = "";
        public string Frase { get; set; } = "";
        public bool Sucess { get; set; } = true;
    }

    internal class Palindromo
    {
        private string _s = "";

        public string S
        {
            get { return _s; }
        }

        public Palindromo(string s)
        {
            this._s = s;
        }

        public ResultadoPalindromo esPalindromo()

        {
            ResultadoPalindromo resultadoPalindromo = new ResultadoPalindromo();
            string minusculas = _s.ToLower();
            string sinEspacios = "";
            int i = 0;

            while (i < minusculas.Length)
            {
                if (minusculas[i] != ' ')
                {
                    sinEspacios += minusculas[i];
                    resultadoPalindromo.Frase += minusculas[i];
                }
                i++;
            }

            int j = sinEspacios.Length - 1;


            while (j >= 0)
            {
                resultadoPalindromo.FraseInversa += sinEspacios[j];
                j--;
            }


            if (resultadoPalindromo.Frase == resultadoPalindromo.FraseInversa)
            {
                resultadoPalindromo.Sucess = true;
            }
            return resultadoPalindromo;
        }
    }
}
