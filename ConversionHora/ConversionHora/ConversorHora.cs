using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionHora
{
	public class ConversorHora : IConvertirHora
	{
		public string ConvertirHora(int Hora)
		{
            if (Hora > 0 && Hora < 23 )
            {
				string[] horas = {
					"doce", "una", "dos", "tres", "cuatro", "cinco",
					"seis", "siete", "ocho", "nueve", "diez", "once", "doce"
					};

				string horaEscrita = ($"Son las {horas[Hora % 12]}");

				return horaEscrita;
			}
            else
            {
				return "La hora tiene que estar comprendida entre 0 y 23 ";
            }
        }
	}
}
