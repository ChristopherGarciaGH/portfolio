using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasTecnicas
{
    public class ResultadoHappyNumber()
    {
        public bool Sucess { get; set; } = true;

    }
    internal class HappyNumber
    {
        private int _n = 0;

        public int N { get { return _n; } }

        public HappyNumber(int n)
        {
            this._n = n;
        }

        public ResultadoHappyNumber IsHappyNumber()
        {
            ResultadoHappyNumber resultadoHappyNumber = new ResultadoHappyNumber();
            if (_n <= 0)
            {
                resultadoHappyNumber.Sucess = false;
                return resultadoHappyNumber;
            }
            else
            {
                //Convertir int a string
                String numero = _n.ToString();
                List<int> NumeroSeparado = new List<int>();


                foreach (var item in numero)
                {
                    if (int.TryParse(item.ToString(), out int NumeroLista))
                    {
                        NumeroSeparado.Add(NumeroLista);
                    }
                }

                /*
                 * Una vez tenemos la lista con los numeros separados tenemos que 
                 * hacer otra lista, se utilizará HashSet porque no permite numeros
                 * duplicados.
                 * Tenemos que guardar en una lista los numeros vistos ya que 
                 * tenemos el riesgo de hacer un bucle infinito
                 */
                HashSet<int> NumerosVistos = new HashSet<int>();
                /*El bucle debe continuar mientras _n sea distinto de 1 y 
                 * el numero no se encuentre en la lista NumerosVistos
                 */
                while (_n != 1 && !NumerosVistos.Contains(_n))
                {
                    NumerosVistos.Add(_n);
                    int SumaCuadrados = 0;

                    foreach (int item in NumeroSeparado)
                    {
                        SumaCuadrados += item * item;
                    }
                    /*
                     * Tenemos que volver a reiniciar la lista Numero separado
                     * ya que tenemos que volver a calcular los cuadrados de
                     * los numeros de la lista 
                     */
                    NumeroSeparado = new List<int>();
                    foreach (var item in SumaCuadrados.ToString())
                    {
                        if(int.TryParse(item.ToString(), out int NumeroLista))
                        {
                            NumeroSeparado.Add(NumeroLista);
                        }
                    }

                    _n = SumaCuadrados;
                }
                
                return resultadoHappyNumber;
            }
        }
    }
}
