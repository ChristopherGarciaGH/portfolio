using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    //Clase que representa la velocidad
    public class Acelerador : IVelocidadAjustable
    {
        private int _velocidad = 0;

        public void AumentarVelocidad()
        {
            _velocidad++;
            Console.WriteLine($"La velocidad ha aumentado: {_velocidad} Km/h");
        }

        public void DisminuirVelocidad()
        {
            _velocidad = Math.Max( 0, _velocidad - 1);
            Console.WriteLine($"La velocidad ha disminuido: {_velocidad} Km/h");
        }
    }
}
