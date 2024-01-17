using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    /*
     * Clase principal: Esta clase utiliza la composicion
     * para agregar funcionalidades, la composicion tambien
     * se puede hacer con abstracciones, Interfaces dando mas potencia
     * a la composicion, de esta forma con una abstraccion se pueden
     * tener distintos tipos de comportamiento en tiempo de ejecucion
     */
    public class Coche
    {
        private ArrancarParar arrancarParar = new ArrancarParar();
        private IVelocidadAjustable velocidad;

        public Coche(IVelocidadAjustable velocidad)
        {
            this.velocidad = velocidad;
        }

        public void Arrancar()
        {
            arrancarParar.Arrancar();
        }

        public void Parar()
        {
            arrancarParar.Parar();
        }

        public void AumentarVelocidad()
        {
            velocidad.AumentarVelocidad();
        }

        public void DisminurVelocidad()
        {
            velocidad.DisminuirVelocidad();
        }

    }
}
