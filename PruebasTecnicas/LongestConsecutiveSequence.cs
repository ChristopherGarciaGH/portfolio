using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasTecnicas
{
    public class SecuenciaMasLarga()
    {
        public int Secuencia { get; set; } = 0;
    }
    internal class LongestConsecutiveSequence
    {
        private int[] _secuencia;

        public LongestConsecutiveSequence(int[] secuencia)
        {
            _secuencia = secuencia;
        }

        public SecuenciaMasLarga SecuenciaObjetivo()
        {
            SecuenciaMasLarga secuenciaMasLarga = new SecuenciaMasLarga();

            HashSet<int> ListaNumeros = new HashSet<int>(_secuencia);

            foreach (int numero in _secuencia)
            {
                int SecuenciaActual = 0;
                int NumeroActual = numero;
                while (ListaNumeros.Contains(NumeroActual))
                {
                    SecuenciaActual++;
                    NumeroActual++;
                }
                secuenciaMasLarga.Secuencia = Math.Max(secuenciaMasLarga.Secuencia, SecuenciaActual);
            }

            return secuenciaMasLarga;
        }
    }
}
