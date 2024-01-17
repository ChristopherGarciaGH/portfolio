using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Herencia
{
    public class Moto : Vehiculo
    {
        public Moto(string marca, string modelo, int anioFabricacion)
            : base(marca, modelo, anioFabricacion)
        {

        }

        public override void Conducir()
        {
            Console.WriteLine("Conduciendo una moto");
        }
    }
}
