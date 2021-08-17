using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.models
{
    public class AnnotherClass : IEmployee
        // this class is also inherited....lets change here too
    {
        //let make this class have single object,, so that we can add methods to get count or to add employee
        List<Employee> emp;
        public AnnotherClass()
        {
            emp = new List<Employee>();
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            // this is fake data from list , not from EF core..
            // lets rectify it quickly to avoid error
            var r1 = Task.Run(() => emp.Add(employee));
            await Task.WhenAll(r1);
            return employee;
        }

        public async Task<int> DeleteEmployee(int id)
        {
            // this is static class...quicky we will do it,,,
            // its not related to EF

            var r1 = Task.Run(() => emp.Remove(emp.First(x=>x.Id==id)));
            await Task.WhenAll(r1);
            return id;
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