using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.models
{
    public interface IEmployee
    {
        // To get all Employees
        public List<Employee> GetEmployee();// will implement it in base class

        public int EmployeeCount();

        public void AddEmployee(Employee emp);

    }
}