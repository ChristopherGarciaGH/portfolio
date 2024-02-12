using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionHora
{
	public class Resultado
	{
		private int _hora { get; set; } = 0;
		private int _minutos { get; set; } = 0;

		public Resultado(int hora, int minutos)
		{
			_hora = hora;
			_minutos = minutos;
		}

		public string Conversor()
		{
			ConversorHora conversorHora = new ConversorHora();
			ConversorMinutos conversorMinutos = new ConversorMinutos();

			string momento = string.Empty;

            if (_hora >= 0 && _hora <=12)
            {
                momento = " de la mañana";
            }
            else
            {
				momento = " de la tarde";
            }

            return conversorHora.ConvertirHora(_hora) + conversorMinutos.ConvertirMinutos(_minutos) + momento;

		}
	}
}
