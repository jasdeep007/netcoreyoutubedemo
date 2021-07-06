using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.models
{
    public class AnnotherClass : IEmployee
    {
        //let make this class have single object,, so that we can add methods to get count or to add employee
        List<Employee> emp;
        public AnnotherClass()
        {
            emp = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            emp.Add(employee);
        }

        public int EmployeeCount()
        {
            return emp.Count();
        }

        public List<Employee> GetEmployee()
        {
            return emp;
        }
    }
}