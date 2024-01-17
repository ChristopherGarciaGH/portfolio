using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    public class ControlCrucero : IVelocidadAjustable
    {
        private int _velocidad = 0;
        public void AumentarVelocidad()
        {
            _velocidad++;
            Console.WriteLine($"Aumenta la velodidad a traves del control de crucero: {_velocidad}");
        }

        public void DisminuirVelocidad()
        {
            _velocidad = (Math.Max(0, _velocidad - 1));
            Console.WriteLine($"Disminuye la velodidad a traves del control de crucero: {_velocidad}");
        }
    }
}
