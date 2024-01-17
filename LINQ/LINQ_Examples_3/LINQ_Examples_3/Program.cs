using LINQ_Examples_2;
using TCPData;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> listaEmpleados = Data.GetEmployees();
        List<Deparment> listaDepartamentos = Data.GetDeparments();

        //Operador Equality
        /*
        //SequenceEqual => Compara dos secuencias son iguales en contenido y orden
        var listaEnteros1 = new List<int> {1, 2, 3, 4, 5, 6};
        var listaEnteros2 = new List<int> {1, 2, 3, 4, 5, 6};

        var boolSecuenciaIgual = listaEnteros1.SequenceEqual(listaEnteros2);

        Console.WriteLine(boolSecuenciaIgual);

        var listaEmpleadosComparar = Data.GetEmployees();
        bool boolSE = listaEmpleados.SequenceEqual(listaEmpleadosComparar, new ComparadorTrabajador());

        Console.WriteLine($"Result: {boolSE}");
        */

        //Operador Concatenation
        //Concat => Concatenacion
        /*
        var listaEnteros1 = new List<int> { 1, 2, 3, 4, 5, 6 };
        var listaEnteros2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        IEnumerable<int> ListaConcatenadaInteger = listaEnteros1.Concat(listaEnteros2);

        foreach (var item in ListaConcatenadaInteger)
        {
            Console.WriteLine(item);
        }

        List<Employee> listaEmpleados2 = new List<Employee>
        {
                new Employee(6,"Fernando","Perez",40000.3m,true,1),
                new Employee(7,"Jose","Onieva",30000.4m,false,2),
        };

        IEnumerable<Employee> resultado = listaEmpleados.Concat(listaEmpleados2);

        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10}");   
        }
        */

        //Operadores Aggregate - Aggregate, Average, Count, Sum, Max
        //Aggregate Operator
        //Este codigo va a calcular el salario total anual aplicando un bono si es gerente
        /*
        decimal totalSalarioAnual = listaEmpleados.Aggregate<Employee, decimal>(0, (totalSalarioAnual, e) =>
        {
            var bonus = (e.IsManager) ? 0.04m : 0.02m;

            totalSalarioAnual = (e.AnnualSalary + (e.AnnualSalary * bonus)) + totalSalarioAnual;

            return totalSalarioAnual;
        });

        Console.WriteLine($"Total salario de todos los empleados (incluyendo bonus): {totalSalarioAnual}");
        */

        //Agregate Operator
        /*
        string data = listaEmpleados.Aggregate<Employee, string, string>("Salario Anual (incluyendo bonus):",
            (s, e) =>
            {
                var bonus = (e.IsManager) ? 0.04m : 0.02m;

                s += $"{e.FirstName}{e.LastName} - {e.AnnualSalary + (e.AnnualSalary * bonus)}";
                return s;
            }, s => s.Substring(0, s.Length -2)   
            );

        Console.WriteLine(data);
        */

        //Operador Average => Promedio
        /*
        decimal media = listaEmpleados.Where(e => e.DeparmentId == 3).Average(e => e.AnnualSalary);

        Console.WriteLine($"Salario medio anual del departamento Tecnologia: {media}");
        */

        //Count => Contar
        /*
        int totalTrabajadores = listaEmpleados.Count(e => e.DeparmentId == 3);
        Console.WriteLine($"Total trabajadores departamento tecnologia: {totalTrabajadores}");
        */

        //Sum => Sumar
        /*
        decimal resultado = listaEmpleados.Sum(e => e.AnnualSalary);
        Console.WriteLine($"Total salario anual: {resultado}");
        */

        //Max => Maximo
        /*
        var resultado = listaEmpleados.Max(e => e.AnnualSalary);
        Console.WriteLine($"Salario maximo anual: {resultado}");
        */

        //Operadores de generacion - DefaultIfEmpty, Empty, Range, Repeat
        //DefaultIfEmpty => Proporciona un valor predeterminado en caso de que la secuencia este vacia
        /*
        List<int> listaInt = new List<int>();
        var newList = listaInt.DefaultIfEmpty();

        Console.WriteLine(newList.ElementAt(0));

        //DefaultIfEmpty
        List<Employee> employees = new List<Employee>
        {
            new Employee(0,"Name","LastName",0,false,0),
        };
        var newListEmployees = employees.DefaultIfEmpty();
        var resultado = newListEmployees.ElementAt(0);

        if (resultado.Id == 0)
        {
            Console.WriteLine($"La lista está vacia");
        };
        */

        //Empty => Crear una coleccion vacia
        /*
        IEnumerable<Employee> listaEmpleadosVacia = Enumerable.Empty<Employee>();

        listaEmpleadosVacia.Add(new Employee { Id = 7, FirstName = "Dan", LastName = "Brown" });

        foreach (var item in listaEmpleadosVacia)
        {
            Console.WriteLine($"{item.FirstName}{item.LastName}");
        }
        */

        //Range => Devuelve una coleccion de valores que estan dentro de un rango especifico
        /*
        var intColeccion = Enumerable.Range(25, 20);
        foreach (var item in intColeccion)
        {
            Console.WriteLine(item);
        }
        */

        //Repeat => Repite el elemento pasado por argumentos
        /*
        var strColeccion = Enumerable.Repeat<string>("Placeholder", 10);
        foreach (var item in strColeccion)
        {
            Console.WriteLine(item);
        }
        */

        //Operadores Set - Distinct, Except, Intersect, Union
        //Distinct => Devuelve los valores unicos de una lista con valores repetidos
        /*
        List<int> list = new List<int> { 1, 2, 1, 4, 6, 2, 6, 7, 8, 7, 7, 7 };
        var resultado = list.Distinct();
        foreach (var item in resultado)
        {
            Console.WriteLine(item);
        }
        */

        //Except => Devuelve los elementos que estan presentes en la primera coleccion pero no en la segunda
        /*
        IEnumerable<int> coleccion1 = new List<int> {1, 2, 3, 4 };
        IEnumerable<int> coleccion2 = new List<int> {3, 4, 5, 6};

        var resultado = coleccion1.Except(coleccion2);
        foreach (var item in resultado)
        {
            Console.WriteLine(item);
        }
        */

        //Intersect => Obtiene los elementos comunes entre dos colecciones
        /*
        var resultados = listaEmpleados.Intersect(listaEmpleados2, new ComparadorTrabajador());
        foreach (var item in resultados)
        {
            Console.WriteLine($"{item.Id, -5}{item.FirstName, -10}{item.LastName,-10}");
        }
        */

        //Union => Obtiene la union (todos los elementos distintos) entre dos colecciones
        /*
        var resultados = listaEmpleados.Union(listaEmpleados2, new ComparadorTrabajador());
        foreach (var item in resultados)
        {
            Console.WriteLine($"{item.Id, -5}{item.FirstName, -10}{item.LastName,-10}");
        }
        */

        //Operadores de particion - Skip, SkipWhile, Take, TakeWhile
        //Skip => Omite un numero determinado en una secuencia
        /*
        var resultado = listaEmpleados.Skip(2);
        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10}");
        }
        */

        //SkipWhile => Omite valores de una secuencia mientras sea true
        /*
        var resultado = listaEmpleados.SkipWhile(e => e.AnnualSalary > 50000);
        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10}");
        }
        */

        //Take => Devuelve un numero especifico de elementos contiguos
        /*
        var resultado = listaEmpleados.Take(2);
        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10}");
        }
        */

        //TakeWhile => Devuelve un numero especifico de elementos contiguos mientras sea true
        /*
        var resultado = listaEmpleados.TakeWhile(e => e.AnnualSalary > 50000);
        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10} {item.AnnualSalary,10}");
        }
        */

        //Operadores de conversion - ToList, ToDictionary, ToArray
        //ToList => Devuelve una coleccion IEnumerable que contiene los resultados de una consulta
        /*
        List<Employee> resultado = (from emp in listaEmpleados
                                    where emp.AnnualSalary > 50000
                                    select emp).ToList();

        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10} {item.AnnualSalary,10}");
        }
        */

        //ToDictionary => Convierte una coleccion IEnumerable en un Dictionary
        /*
        Dictionary<int, Employee> diccionario = (from emp in listaEmpleados
                                                 where emp.AnnualSalary > 50000
                                                 select emp).ToDictionary<Employee, int>(e => e.Id);

        foreach (var key in diccionario.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {diccionario[key].FirstName}{diccionario[key].LastName}");
        }
        */

        //ToArray => Convierte una coleccion IEnumerable en un Array
        /*
        Employee[] resultado = (from emp in listaEmpleados
                                 where emp.AnnualSalary > 50000
                                 select emp).ToArray();

        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10} {item.AnnualSalary,10}");
        }
        */

        //Clausulas Let y Into
        //Let => Introduce una variable que puede ser utilizada dentro de la propia consulta
        /*
        var resultado = from emp in listaEmpleados
                        let Iniciales = emp.FirstName.Substring(0, 1).ToUpper() + emp.LastName.Substring(0, 1).ToUpper()
                        let SalarioAnualPlusBonus = (emp.IsManager) ? emp.AnnualSalary + (emp.AnnualSalary * 0.04m) : emp.AnnualSalary + (emp.AnnualSalary * 0.02m)
                        where Iniciales == "MR" || Iniciales == "LM" && SalarioAnualPlusBonus > 50000
                        select new
                        {
                            Iniciales = Iniciales,
                            NombreCompleto = emp.FirstName + "" + emp.LastName,
                            SalarioAnualPlusBonus = SalarioAnualPlusBonus
                        };

        foreach (var item in resultado)
        {
            Console.WriteLine($"{item.Iniciales,-5}{item.NombreCompleto,-10}{item.SalarioAnualPlusBonus,-10}");
        }
        */

        //Into => Realiza operaciones adicinales en una consulta y almacena los resultados en una nueva variable
        
        var resultados = from emp in listaEmpleados
                         where emp.AnnualSalary > 50000
                         select emp
                         into IngresosAltos
                         where IngresosAltos.IsManager == true
                         select IngresosAltos;

        foreach (var item in resultados)
        {
            Console.WriteLine($"{item.Id,-5}{item.FirstName,-10}{item.LastName,-10}");
        }
        
    }


}