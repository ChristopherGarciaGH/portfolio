using ConversionHora;

internal class Program
{
	private static void Main(string[] args)
	{
		Resultado resultado = new Resultado(13, 05);
		Console.WriteLine(resultado.Conversor());
	}
}