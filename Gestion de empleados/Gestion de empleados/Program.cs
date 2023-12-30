using Gestion_de_empleados;

internal class Program
{
    private static void Main(string[] args)
    {
        //Lista de Administrativos
        List<Administrativo> administrativos = new List<Administrativo>
        {
            new Administrativo(1,"Pepe",1100,100),
            new Administrativo(2,"Juan",1200,300),
        };

        //Calculadora salario para administrativos
        var CalculadoraAdministrativos = new CalculadoraSalario<Administrativo>(administrativos);

        // Calcular y mostrar el promedio de salario para los administrativos
        double PromedioAdministrativos = CalculadoraAdministrativos.CalcularSueldoPromedio();
        // :F2 = Formatear con dos decimales
        Console.WriteLine($"Promedio salario Administrativos: {PromedioAdministrativos:F2}");

        //Lista de Desarrolladores
        List<Desarrollador> desarrolladores = new List<Desarrollador>
        {
            new Desarrollador(1,"Luis",1800,300),
            new Desarrollador(2,"Antonio",2000,300),
        };

        //Crear una calculadora para Desarrolladores
        var CalculadoraDesarrolladores = new CalculadoraSalario<Desarrollador>(desarrolladores);

        //Calcular y mostrar el promedio de salario para los desarrolladores
        double PromedioDesarrolladores = CalculadoraDesarrolladores.CalcularSueldoPromedio();
        Console.WriteLine($"Promedio salario Administrativos: {PromedioDesarrolladores:F2}");
    }
}