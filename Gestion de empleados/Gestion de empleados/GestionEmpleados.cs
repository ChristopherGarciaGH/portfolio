using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_empleados
{
    public class GestionEmpleados <T> where T : Empleado, Isalario
    {
        private readonly List<T> _lista;

        public GestionEmpleados(List<T> lista)
        {
            _lista = lista ?? throw new ArgumentNullException(nameof(lista));
            //EliminarDuplicados();
        }

        public void AddItem(T item)
        {
            if (_lista.Find(i => i.Id == item.Id) == null)
            {
                _lista.Add(item);
            }
        }

        public void RemoveItem(T item) => _lista.Remove(item);

        public void Clear() => _lista.Clear();

        public List<T> MostrarTrabajadores()
        {
            return _lista.OrderBy(x => x.Nombre).ToList();
        }

        public List<T> MostrarTrabajoresPorNombre(String nombre)
        {
            //Visual Studio nos obliga a añadir a la consulta StringComparison
            return _lista.Where(x => x.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public T? MostrarTrabajadoresPorId(int id)
        {
            T? _trabajador = _lista.FirstOrDefault(x => x.Id == id);
            if (_trabajador == null)
            {
                throw new InvalidOperationException("No se encontro ningun trabajador");
            }
            return _trabajador;
        }

    }
}
