using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1,"Antonio","Varon",60000.3m,true,1),
                new Employee(2,"Luis","Moya",50000.4m,false,1),
                new Employee(3,"Jose Luis","Moreno",45000.5m,true,2),
                new Employee(4,"Manuel","Ruiz",70000.6m,true,3),
                new Employee(5,"Fernando","Cortes",54000.5m,false,2),
            };

            return employees;
        }

        public static List<Deparment> GetDeparments()
        {
            List<Deparment> deparments = new List<Deparment>
            {
                new Deparment(1,"HR","Recursos Humanos"),
                new Deparment(2,"FN","Finanzas"),
                new Deparment(3,"TE","Tecnologia")
            };

            return deparments;
        }
    }
}
