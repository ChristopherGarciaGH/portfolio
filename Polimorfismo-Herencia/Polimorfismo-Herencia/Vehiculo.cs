using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Herencia
{
    public abstract class Vehiculo
    {
        private string _marca = string.Empty;
        protected string _modelo = string.Empty;
        protected int _anioFabricacion;
        
        public Vehiculo(string  marca, string modelo, int anioFabricacion)
        {
            _marca = marca;
            _modelo = modelo;
            _anioFabricacion = anioFabricacion;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Vehiculo: {_marca}{_modelo}{_anioFabricacion}");
        }

        public abstract void Conducir();
    }
}
