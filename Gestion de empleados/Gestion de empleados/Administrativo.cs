using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_empleados
{
    internal class Administrativo : Empleado, Isalario
    {
        /*
         * Base:
         * Invoca al constructor desde el constructor de la clase derivada
         * Derivada: Administrativo
         * Base: Empleado
         */
        public Administrativo(int id, String nombre, int salarioBase, int suplidos) : base(id, nombre, salarioBase, suplidos) { }

        public int CalcularSalario()
        {
            return SalarioBase + Suplidos;
        }

        /*
         * Expresion lambda:
         * public bool SalarioAlto() => (this.CalcularSalario() > 2000);
         * 
         * Es lo mismo que el metodo de abajo
         */
        public bool SalarioAlto()
        {
            int SalarioTotal = this.CalcularSalario();

            if (SalarioTotal > 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
