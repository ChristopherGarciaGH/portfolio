using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_empleados
{
    internal class Desarrollador : Empleado, Isalario
    {
        public Desarrollador (int id, String nombre, int salarioBase, int suplidos) : base(id, nombre, salarioBase, suplidos) { }

        public int CalcularSalario()
        {
            int disponibilidad = 200; 
            return SalarioBase + Suplidos + disponibilidad;
        }

        public bool SalarioAlto() => (this.CalcularSalario() > 10000);
    }
}
