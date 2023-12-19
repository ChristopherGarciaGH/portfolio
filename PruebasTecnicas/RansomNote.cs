using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasTecnicas
{
    public class ResultadoRansomNote()
    {
        public bool Sucess { get; set; } = true;
    }
    internal class RansomNote
    {
        private String _ransomNote { get; } = "";
        private String _magazine { get; } = "";

        public RansomNote(string ransomNote, string magazine)
        {
            this._ransomNote = ransomNote;
            this._magazine = magazine;
        }

        public ResultadoRansomNote CanConstruct()
        {
            ResultadoRansomNote rn = new ResultadoRansomNote();
            Dictionary <char,int> ContadorLetras = new Dictionary<char,int>();
            /*
             * La eleccion de un diccionario es porque nos permite guardar una
             * letra que sera "clave primaria" como en una base de datos y tambien
             * podremos guardar el numero de veces que se repite una letra
             */

            /*
             * Con este foreach añadimos las letras de _ransomNote al diccionario de forma
             * que vamos a guardar por una parte la letra y gracias al bucle foreach ademas
             * de guardar cuantas veces se repite la misma letra
             */
            foreach (char letra in _ransomNote)
            {
                if (ContadorLetras.ContainsKey(letra))
                {
                    ContadorLetras[letra]++;
                }
                else
                {
                    ContadorLetras[letra] = 1;
                }
            }

            /*
             * En este bucle foreach lo que vamos a mirar es si podemos construir una 
             * RansomNote de forma que si el resultado es 0 significa que con las
             * letras del diccionario que hemos creado podemos crear una RansomNote
             * si nos quedamos por debajo de 0 significa que nos faltarian letras para
             * construir la RansomNote
             */

            foreach (char letra in _magazine)
            {
                if (ContadorLetras.ContainsKey(letra))
                {
                    ContadorLetras[letra]--;

                    if (ContadorLetras[letra]<0)
                    {
                        rn.Sucess = false;
                    }
                }

            }
            return rn;

        }
    }
}
