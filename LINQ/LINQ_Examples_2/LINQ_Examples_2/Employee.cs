using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public class Employee
    {
        private int _id = 0;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private decimal _annualSalary = 0;
        private bool _isManager = true;
        private int _deparmentId = 0;

        public int Id { get { return _id; } set { _id = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public decimal AnnualSalary { get { return _annualSalary; } set { _annualSalary = value; } }
        public bool IsManager { get { return _isManager; } set { _isManager = value; } }
        public int DeparmentId { get { return _deparmentId; } set { _deparmentId = value; } }

        public Employee(int id, string firstName, string lastName, decimal annualSalary, bool isManager, int departmentId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
            IsManager = isManager;
            DeparmentId = departmentId;
        }
    }
}
