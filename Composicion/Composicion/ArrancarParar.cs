using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    //Clase que recoje la funcionalidad de arrancar y parar
    public class ArrancarParar
    {
        private bool _contacto = false;

        public void Arrancar()
        {
            _contacto = true;
            Console.WriteLine("El coche ha arrancado");
        }

        public void Parar()
        {
            _contacto = false;
            Console.WriteLine("El coche está parado");
        }
    }
}
