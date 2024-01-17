using TCPData;
using TCPExtensions;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        List<Employee> listaEmpleados = Data.GetEmployees();

        var filtroEmpleados = listaEmpleados.Filtro(emp => emp.IsManager == false);
        var filtroEmpleados = listaEmpleados.Filtro(emp => emp.AnnualSalary < 50000);

        foreach (var empleado in filtroEmpleados)
        {
            Console.WriteLine($"Nombre: {empleado.FirstName}");
            Console.WriteLine($"Apellidos: {empleado.LastName}");
            Console.WriteLine($"Salario Anual: {empleado.AnnualSalary}");
            Console.WriteLine($"Es manager: {empleado.IsManager}");
        }
        */

        /*
        List<Deparment> listaDepartamentos = Data.GetDeparments();

        var filtroDepartamentos = listaDepartamentos.Where(dept => dept.ShortName == "HR" || dept.ShortName == "FN");

        foreach (var departamento in filtroDepartamentos)
        {
            Console.WriteLine($"ID Departamento: {departamento.Id}");
            Console.WriteLine($"Nombre corto: {departamento.ShortName}");
            Console.WriteLine($"Nombre largo: {departamento.LongName}");
        }
        */

        List<Employee> listaEmpleados = Data.GetEmployees();
        List<Deparment> listaDepartamentos = Data.GetDeparments();

        var listaResultado = from emp in listaEmpleados
                             join dept in listaDepartamentos
                             on emp.DeparmentId equals dept.Id
                             select new
                             {
                                 Nombre = emp.FirstName,
                                 Apellidos = emp.LastName,
                                 SalarioAnual = emp.AnnualSalary,
                                 Manager = emp.IsManager,
                                 Departamento = dept.LongName
                             };

        foreach (var empleado in listaResultado)
        {
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine($"Apellidos: {empleado.Apellidos}");
            Console.WriteLine($"Salario Anual: {empleado.SalarioAnual}");
            Console.WriteLine($"Es manager: {empleado.Manager}");
            Console.WriteLine($"Departamento: {empleado.Departamento}");
        }

        var mediaSalarioAnual = listaResultado.Average(x => x.SalarioAnual);
        var salarioMasAlto = listaResultado.Max(x => x.SalarioAnual);
        var salarioMasBajo = listaResultado.Min(x => x.SalarioAnual);
    }
}