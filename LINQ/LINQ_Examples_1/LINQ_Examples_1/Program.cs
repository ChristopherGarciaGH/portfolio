using TCPData;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> listaEmpleados = Data.GetEmployees();
        List<Deparment> listaDepartamentos = Data.GetDeparments();

        //Method Syntax
        /*
        var resultado = listaEmpleados.Select(e => new
        {
            NombreEmpleado = e.FirstName + " " + e.LastName,
            SalarioAnual = e.AnnualSalary
        }).Where(e => e.SalarioAnual >=50000);

        foreach (var item in resultado)
        {
            //El -20 y el 10 son espacios para mostrar correctamente por consola
            Console.WriteLine($"{item.NombreEmpleado, -20}{item.SalarioAnual,10}");
        }
        */

        //Query syntaxis
        // Microsoft recomienda usar Query Syntaxis +legibilidad
        /*
        var resultado = from emp in listaEmpleados
                        where emp.AnnualSalary >= 50000
                        select new
                        {
                            NombreEmpleado = emp.FirstName + " " + emp.LastName,
                            SalarioAnual = emp.AnnualSalary
                        };

        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.NombreEmpleado,-20}{item.SalarioAnual,10}");
        }
        */

        //Join - Method Syntax
        /*
        var resulado = listaDepartamentos.Join(listaEmpleados,
            Departamento => Departamento.Id,
            Empleado => Empleado.DeparmentId,
            (Departamento, Empleado) => new
            {
                NombreCompleto = Empleado.FirstName + " " + Empleado.LastName,
                SalarioAnual = Empleado.AnnualSalary,
                NombreDepartamento = Departamento.LongName
            }
            );

        foreach (var item in resulado)
        {
            Console.WriteLine($"{item.NombreCompleto,-20}{item.SalarioAnual,-10}{item.NombreDepartamento}");
        }
        */

        //Join - Query Syntax
        /*
        var resultado = from dept in listaDepartamentos
                        join emp in listaEmpleados
                        on dept.Id equals emp.DeparmentId
                        select new
                        {
                            NombreCompleto = emp.FirstName + " " + emp.LastName,
                            SalarioAnual = emp.AnnualSalary,
                            NombreDepartamento = dept.LongName
                        };

        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.NombreCompleto,-20}{item.SalarioAnual,-10}{item.NombreDepartamento}");
        }
        */

        //Group Join - Method Syntax
        /*
        var resultado = listaDepartamentos.GroupJoin(listaEmpleados,
            dept => dept.Id,
            emp => emp.DeparmentId,
            (dept, grupoEmpleados) => new
            {
                Empleados = grupoEmpleados,
                NombreDepartamento = dept.LongName
            });

        foreach (var item in resultado)
        {
            Console.WriteLine($"Nombre Departamento: {item.NombreDepartamento}");
            foreach (var emp in item.Empleados)
            {
                Console.WriteLine($"\t{emp.FirstName}{emp.LastName}");
            }
        }
        */

        //Group Join - Query Syntax
        var resultado = from dept in listaDepartamentos
                        join emp in listaEmpleados
                        on dept.Id equals emp.DeparmentId
                        into grupoEmpleados
                        select new
                        {
                            Empleados = grupoEmpleados,
                            NombreDepartamento = dept.LongName
                        };

        foreach ( var item in resultado )
        {
            Console.WriteLine($"Nombre Departamento: {item.NombreDepartamento}");
            foreach (var emp in item.Empleados)
            {
                Console.WriteLine($"\t{emp.FirstName}{emp.LastName}");
            }
        }

    }
}