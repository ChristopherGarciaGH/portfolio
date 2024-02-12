
namespace ConversionHora
{
	public class ConversorMinutos : IConvertirMinutos
	{
		public string ConvertirMinutos(int Minutos)
		{
			if (Minutos > 0 || Minutos < 59)
			{

				string[] minutos = {
					"en punto", "una", "dos", "tres", "cuatro", "cinco",
					"seis", "siete", "ocho", "nueve", "diez", "once", "doce",
					"trece", "catorce", "y cuarto", "dieciseis", "diecisiete",
					"dieciocho", "diecinueve","veinte", "veintiún", "veintidós",
					"veintitrés", "veinticuatro", "veinticinco", "veintiséis",
					"veintisiete","veintiocho", "veintinueve", "media"
					};

                if (Minutos <= 30)
                {
					string MinutosEscritos = ($" y {minutos[Minutos]}");
					return MinutosEscritos;
                }

				else
				{
					string MinutosEscritos = ($" menos{minutos[Minutos]}");
					return MinutosEscritos;
				}
			}
			else
			{
				return "Los minutos tienen que estar comprendida entre 0 y 59 ";
			}
		}
	}
}