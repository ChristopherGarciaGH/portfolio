using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_empleados
{
    /*
     * Generic Class:
     * Haciendo uso del polimorfismo, esta tipo de clase nos permite
     * trabajar con distintos tipos de datos (int, String, Double..)
     * sin tener que crear una clase especifica para cada tipo de
     * dato.
     * 
     */
    public class CalculadoraSalario<T> where T : Empleado, Isalario
    {
        private readonly List<T> _lista;

        /*
         * Constructor de la clase Generic
         * El operador ?? proporciona un valor predeterminado
         * en este caso lanza una excepcion.
         */
        public CalculadoraSalario(List<T> lista)
        {
            _lista = lista ?? throw new ArgumentNullException(nameof(lista));

            //Detectar duplicados por Id y eliminarlos
            EliminarDuplicados();
        }

        public void AddItem(T item)
        {
            //Antes de añadir a la lista se comprueban que existen

            /*
             * Version simplificada:
             * if(_lista.Find(i => i.Id == item.Id == null)
             * {
             * _lista.Add(item);
             */
            bool _existe = false;

            foreach (T _elementoExistente in _lista)
            {
                if (_elementoExistente.Id == item.Id)
                {
                    _existe = true;
                    break;
                }
            }
            if (!_existe)
            {
                _lista.Add(item);
            }
        }

        /*
         * Version simplificada:
         * public void RemoveItem(T item) => _lista.Remove(item);
         */
        public void RemoveItem(T item)
        {
            _lista.Remove(item);
        }

        /*
         * Version simplificada:
         *public void Clear() => _lista.Clear();
         */
        public void Clear(T item)
        {
            _lista.Clear();
        }

        public double CalcularSueldoPromedio()
        {
            if (_lista.Count == 0)
            {
                throw new InvalidOperationException("La lista no puede estar vacia");
            }
            /*
             * La instruccion incluye LINQ y Polimormismo:
             * 
             * LINQ = Nos permite realizar consultas con una sintaxis 
             * similar a SQL se puede usar en colecciones de objetos
             * bases de datos, servicios web y otros origenes de datos.
             * 
             * Polimorfismo = Se involucra al llamar al metodo CalcularSalario
             */
            return _lista.Average(x => x.CalcularSalario());
        }

        private void EliminarDuplicados()
        {
            var idsUnicos = new HashSet<int>();
            /*
             * Version simplificada:
             * for (int i = _lista.Count - 1; i >= 0; i--)
             * {
             * if (!idsUnicos.Add(_lista[i].Id))
             * {
             * _lista.RemoveAt(i);
             * }
             * }
             */
            _lista.RemoveAll(item => !idsUnicos.Add(item.Id));
        }

        public double CalcularSueldoTotal()
        {
            if (_lista.Count == 0)
            {
                throw new InvalidOperationException("La lista no puede estar vacia");
            }
            else
            {
                return _lista.Sum(x => x.CalcularSalario());
            }
        }
        
        public double SalarioMasAlto()
        {
            if (_lista.Count == 0)
            {
                throw new InvalidOperationException("La lista no puede estar vacia");
            }
            else
            {
                return _lista.Max(x => x.CalcularSalario());
            }
        }
    }
}
