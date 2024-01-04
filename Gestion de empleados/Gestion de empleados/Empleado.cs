using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_empleados
{
    public class Empleado
    {
        private int _id = 0;
        private String _nombre = String.Empty;
        private int _salarioBase = 0;
        private int _suplidos = 0;

        public int Id { get { return _id; } set {  _id = value; } }
        public String Nombre { get { return _nombre; } set { _nombre = value; } }
        public int SalarioBase { get {  return _salarioBase; } set
            {
                if (value > 1000)
                {
                    _salarioBase = value;
                }
                else
                {
                    throw new ArgumentException("El salario debe ser superior a 1000");
                }
            } }
        public int Suplidos {  get { return _suplidos; } set
            {
                if (value > 0)
                {
                    _suplidos = value;
                }
                else
                {
                    throw new ArgumentException("No puede haber suplidos negativos");
                }
            } }

        public Empleado(int id, string nombre, int salarioBase, int suplidos)
        {
            Id = id;
            Nombre = nombre;
            SalarioBase = salarioBase;
            Suplidos = suplidos;
        }

        public override string ToString()
        {
            return $"Id: {Id} Nombre: {Nombre} Salario Base: {SalarioBase} Suplidos: {Suplidos}";
        }
    }
}
