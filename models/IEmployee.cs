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

        // lets rectify it
        public Task<Employee> AddEmployee(Employee emp);

        public Task<int> DeleteEmployee(int id);

    }
}