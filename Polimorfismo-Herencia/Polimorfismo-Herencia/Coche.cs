using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Herencia
{
    public class Coche : Vehiculo
    {
        public string _combustible { get; set; }

        public Coche(string combustible, string marca, string modelo, int anioFabricacion)
            : base(marca, modelo, anioFabricacion)
        {
            _combustible = combustible;
        }

        public override void Conducir()
        {
            Console.WriteLine("Conduciendo un coche");
        }
    }
}
