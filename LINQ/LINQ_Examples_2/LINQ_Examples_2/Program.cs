using LINQ_Examples_2;
using System.Collections;
using TCPData;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> listaEmpleados = Data.GetEmployees();
        List<Deparment> listaDepartamentos = Data.GetDeparments();

        //OrderBy y ThenBy - Method Syntax
        /*
        var resultado = listaEmpleados.Join(listaDepartamentos, e => e.DeparmentId, d => d.Id,
            (emp, dept) => new
            {
                Id = emp.Id,
                Nombre = emp.FirstName,
                Apellido = emp.LastName,
                SalarioAnual = emp.AnnualSalary,
                DepartamentoId = emp.DeparmentId,
                NombreDepartamento = dept.LongName
            }).OrderBy(o => o.DepartamentoId).ThenBy(o => o.SalarioAnual);
        // Para ordenar de forma inversa .OrderByDescending
        // ThenBy => Si hay departamentos con el mismo Id, se ordenaran de forma ascendente por el campo Salario Anual
        // Para ordenar de forma inversa .ThenByDescending

        foreach (var item in resultado)
        {
            Console.WriteLine($"Id: {item.Id,-5} Nombre: {item.Nombre, -10}, Apellido: {item.Apellido,-10}, Salario Anual: {item.SalarioAnual,10}\tNombre Departamento: {item.NombreDepartamento}");
        }
        */

        //Query Syntax
        /*
        var resultado = from emp in listaEmpleados
                        join dept in listaDepartamentos
                        on emp.DeparmentId equals dept.Id
                        orderby emp.DeparmentId, emp.AnnualSalary descending
                        select new
                        {
                            Id = emp.Id,
                            Nombre = emp.FirstName,
                            Apellido = emp.LastName,
                            SalarioAnual = emp.AnnualSalary,
                            DepartamentoId = emp.DeparmentId,
                            NombreDepartamento = dept.LongName
                        };

        foreach (var item in resultado)
        {
            Console.WriteLine($"Id: {item.Id,-5} Nombre: {item.Nombre,-10}, Apellido: {item.Apellido,-10}, Salario Anual: {item.SalarioAnual,10}\tNombre Departamento: {item.NombreDepartamento}");
        }
        */

        //Grouping Operators
        //GroupBy => Agrupa los elementos segun la clave unique que le pasemos
        /*
        var resultadoGrupo = from emp in listaEmpleados
                             orderby emp.DeparmentId
                             group emp by emp.DeparmentId;
        foreach (var empGrupo in resultadoGrupo)
        {
            Console.WriteLine($"Id Departamento: {empGrupo.Key}");
            foreach (Employee emp in empGrupo)
            {
                Console.WriteLine($"\tNombre Completo: {emp.FirstName} {emp.LastName}");
            }
        }
        */

        //ToLookup => Agrupa los elementos al igual que GroupBy pero orientada a una busqueda directa

        /*
        var resultadoGrupo = listaEmpleados.OrderBy(o => o.DeparmentId).ToLookup(e => e.DeparmentId);

        foreach (var empGrupo in resultadoGrupo)
        {
            Console.WriteLine($"Id Departamento: {empGrupo.Key}");
            foreach (Employee emp in empGrupo)
            {
                Console.WriteLine($"\tNombre Completo: {emp.FirstName} {emp.LastName}");
            }
        }
        */

        //Operadores Cuantificadores: All, Any, Contains
        //Operadores All y Any 
        /*
        var CompararSalarioAnual = 70000;

        bool isTrueAll = listaEmpleados.All(e => e.AnnualSalary > CompararSalarioAnual);
        if (isTrueAll)
        {
            Console.WriteLine($"Todos los salarios anuales estan por encima de {CompararSalarioAnual}");
        }
        else
        {
            Console.WriteLine($"No todos los salarios anuales estan por encima de {CompararSalarioAnual}");
        }

        bool isTrueAny = listaEmpleados.Any(e => e.AnnualSalary > CompararSalarioAnual);
        if (isTrueAll)
        {
            Console.WriteLine($"Al menos un empleado tiene un salario anual por encima de {CompararSalarioAnual}");
        }
        else
        {
            Console.WriteLine($"No hay ningun empleado con un salario anual por encima de {CompararSalarioAnual}");
        }
        */

        //Operador Contains
        /*
        var buscadorTrabajador = new Employee(4, "Manuel", "Ruiz", 70000.6m, true, 3);

        bool contieneTrabajador = listaEmpleados.Contains(buscadorTrabajador, new ComparadorTrabajador());

        if (contieneTrabajador)
        {
            Console.WriteLine($"Se ha encontrado un registro para {buscadorTrabajador.FirstName} {buscadorTrabajador.LastName}");
        }
        else
        {
            Console.WriteLine($"No se ha encontrado un registro para {buscadorTrabajador.FirstName} {buscadorTrabajador.LastName}");
        }
        */

        //OfType filter
        // OfType => Se va a guardar en la variable resultadoString el tipo de dato que le pasemos por parametro en este caso de tipo string
        ArrayList mixedCollection = Data.GetColeccionDatosHeterogenea();

        /*
         * //Imprimir todos los string
        var resultadoString = from s in mixedCollection.OfType<string>()
                              select s;
        */

        //Imprimir todos los int
        /*
        var resultadoInt = from i in mixedCollection.OfType<int>()
                              select i;

        foreach (var item in resultadoInt)
        {
            Console.WriteLine(item);
        }
        */

        //Imprimir empleados
        /*
        var resultadoEmpleados = from e in mixedCollection.OfType<Employee>()
                                 select e;

        foreach (var emp in resultadoEmpleados)
        {
            Console.WriteLine($"{emp.Id,-5}{emp.FirstName,-10}{emp.LastName,-10}");
        }
        */

        //Imprimir departamentos
        /*
        var resultadoDepartamentos = from d in mixedCollection.OfType<Deparment>()
                                     select d;

        foreach (var dept in resultadoDepartamentos)
        {
            Console.WriteLine($"{dept.Id,-5}{dept.LongName,-10}{dept.ShortName,-10}");
        }
        */

        /*
         * ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single and SingleOrDefault
         * -------------------------------------------------------------------------------------------------------------------------
         * ElementAt => Se utiliza para obtener el elemento de una posicion especifica
         * ElementAtOrDefault => Similar a ElementAt pero en caso de no existir el indice, devuelve un valor predeterminado
         * First => Se utiliza para obtener el primer elemento de una secuencia
         * FirstOrDefault => Similar a First pero en lugar de lanzar una excepcion, devuelve un valor predeterminado
         * Last => Se utiliza para obtener el ultimo elemento
         * LastOrDefault => Igual que Last, solo que en lugar de lanzar una excepcion, devuelve un valor predeterminado
         * Single => Se utiliza cuando esperas que haya exactamente un elemento en la secuencia
         * SingleOrDefault => Igual que Single, solo que en lugar de lanzar una excepcion, devuelve un valor predeterminado
         * -------------------------------------------------------------------------------------------------------------------------
        */


        //ElementAt
        /*
        var emp = listaEmpleados.ElementAt(1);
        Console.WriteLine($"{emp.Id,-5}{emp.FirstName,-10}{emp.LastName,-10}");

        //ElementAtOrDefault
        var empl = listaEmpleados.ElementAtOrDefault(8);
        if (empl!=null)
        {
            Console.WriteLine($"{empl.Id,-5}{empl.FirstName,-10}{empl.LastName,-10}");
        }
        else
        {
            Console.WriteLine("Este empleado no existe en la coleccion");
        }
        */

        //First, FirstOrDefault, Last, LastOrDefault
        List<int> listaEnteros = new List<int> { 3, 14, 23, 17, 28, 89};
        List<int> listaEnterosDefault = new List<int> { 3, 13, 23, 17, 25, 89 };

        int resultadoFirst = listaEnteros.First(i => i % 2 == 0);
        Console.WriteLine($"First:{ resultadoFirst}");

        int resultadoFirstDefault = listaEnterosDefault.FirstOrDefault(i => i % 2 == 0);
        if (resultadoFirstDefault !=0)
        {
            Console.WriteLine($"FirstOrDefault:{resultadoFirstDefault}");
        }
        else
        {
            Console.WriteLine("No hay ningun numero con esas caracteristicas en la coleccion");
        }

        int resultadoLast = listaEnteros.Last(i => i % 2 == 0);
        Console.WriteLine($"Resultado Last:{resultadoLast}");

        int resultadoLastOrDefault = listaEnterosDefault.LastOrDefault(i => i % 2 == 0);
        if (resultadoLastOrDefault != 0)
        {
            Console.WriteLine($"LastOrDefault:{resultadoLastOrDefault}");
        }
        else
        {
            Console.WriteLine("No hay ningun numero con esas caracteristicas en la coleccion");
        }

        //Single
        var emp = listaEmpleados.Single(e => e.Id == 2);
        Console.WriteLine($"{emp.Id,-5}{emp.FirstName,-10}{emp.LastName,-10}");

        //SingleOrDefault
        var empDefault = listaEmpleados.SingleOrDefault(e => e.Id == 3);
        if (empDefault!=null)
        {
            Console.WriteLine($"{empDefault.Id,-5}{empDefault.FirstName,-10}{empDefault.LastName,-10}");
        }
        else
        {
            Console.WriteLine("El empleado no existe en la coleccion");
        }

    }
}