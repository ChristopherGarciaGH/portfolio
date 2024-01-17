using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPData;

namespace LINQ_Examples_2
{
    /*
     * Esta clase se ha creado de la siguiente manera:
     * Se ha creado una clase y despues se le ha implementado la interfaz IEqualityComparer
     * Despues se ha generado el codigo automaticamente
     * 
     * Esta clase compara la igualdad entre dos objetos de tipo "Employee"
     * Tambien genera un codigo hash que luego debe de ser igual al otro hash del objeto que se va a comparar
     * 
     */
    public class ComparadorTrabajador : IEqualityComparer<Employee>
    {
        bool IEqualityComparer<Employee>.Equals(Employee? x, Employee? y)
        {
            if (x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
            {
                return true;   
            }
            return false;
        }

        int IEqualityComparer<Employee>.GetHashCode(Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
