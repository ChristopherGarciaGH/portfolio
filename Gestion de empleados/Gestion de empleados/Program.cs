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
            new Administrativo(3,"Juan Antonio",1300,100),
        };

        //Calculadora salario para administrativos
        var CalculadoraAdministrativos = new CalculadoraSalario<Administrativo>(administrativos);

        // Calcular y mostrar el promedio de salario para los administrativos
        double PromedioAdministrativos = CalculadoraAdministrativos.CalcularSueldoPromedio();
        // :F2 = Formatear con dos decimales
        Console.WriteLine($"Promedio salario Administrativos: {PromedioAdministrativos:F2}");

        //Calcular y mostrar salario total de los administrativos 
        double SumaAdministrativos = CalculadoraAdministrativos.CalcularSueldoTotal();
        Console.WriteLine($"Salario total Desarrolladores: {SumaAdministrativos}");

        //Lista de Desarrolladores
        List<Desarrollador> desarrolladores = new List<Desarrollador>
        {
            new Desarrollador(1,"Luis",1800,600),
            new Desarrollador(2,"Antonio",2100,300),
        };

        //Crear una calculadora para Desarrolladores
        var CalculadoraDesarrolladores = new CalculadoraSalario<Desarrollador>(desarrolladores);

        //Calcular y mostrar el promedio de salario para los desarrolladores
        double PromedioDesarrolladores = CalculadoraDesarrolladores.CalcularSueldoPromedio();
        Console.WriteLine($"Promedio salario Desarrolladores: {PromedioDesarrolladores:F2}");

        //Calcular y mostrar salario total de los desarrolladores 
        double SumaDesarrolladores = CalculadoraDesarrolladores.CalcularSueldoTotal();
        Console.WriteLine($"Salario total Desarrolladores: {SumaDesarrolladores}");

        //Mostrar el salario mas alto de los desarrolladores
        double SalarioMasAlto = CalculadoraDesarrolladores.SalarioMasAlto();
        Console.WriteLine($"El salario mas alto es: {SalarioMasAlto}");

        //Consultas con LINQ
        var ConsultasAdministrativos = new GestionEmpleados<Administrativo>(administrativos);

        //Mostrar trabajadores
        foreach (var administrativo in ConsultasAdministrativos.MostrarTrabajadores())
        {
            Console.WriteLine($"Id: {administrativo.Id}, Nombre: {administrativo.Nombre}");
        }

        //Mostrar trabajadores filtrando por nombre
        String _filtroNombre = "ju";
        foreach (var administrativo in ConsultasAdministrativos.MostrarTrabajoresPorNombre(_filtroNombre))
        {
            Console.WriteLine($"Id: {administrativo.Id}, Nombre: {administrativo.Nombre}");
        }

        //Mostrar trabajadores por Id
        int _id = 1;
        Console.WriteLine(ConsultasAdministrativos.MostrarTrabajadoresPorId(_id));
    }
}