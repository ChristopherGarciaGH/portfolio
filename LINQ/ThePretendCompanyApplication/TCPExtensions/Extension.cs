using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPExtensions
{
    public static class Extension
    {
        /*
         * Este metodo proporciona un flitro personalizado
         * 
         * this List<T> => El this nos indica que es una extension
         * del tipo List<T>, esto nos permite llamar al metodo
         * desde cualquier instancia List<T> como si fuera un metodo propio.
         * 
         * Func<T, bool> func => El segundo parametro es una funcion (func)
         * que toma un elemento del tipo T y devuelve un bool, este parametro
         * se utiliza para determinar si un elemento debe incluirse en la lista filtrada
         * 
         */
        public static List<T> Filtro<T>(this List<T> records, Func<T, bool> func)
        {
            List<T> listaFiltrada = new List<T>();

            foreach (T record in records)
            {
                if (func(record))
                {
                    listaFiltrada.Add(record);
                }
            }
            return listaFiltrada;
        }
    }
}
