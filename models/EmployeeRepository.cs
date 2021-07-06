using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.models
{
    //Here we are using the concept of inheritance,
    // If you are new to that, please visit 
    // youtube.outtm.com
    public class EmployeeRepository : IEmployee
    {

        // this is other class from same interface,,,
        // but we are not using it,, so we can ignore it..
        public void AddEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public int EmployeeCount()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployee()
        {
            return new List<Employee>() {
                new Employee(){ Id=1,Department="HR",Name="employee one"},
                new Employee(){ Id=2,Department="IT",Name="employee two"},
                new Employee(){ Id=3,Department="MANAGEMENT",Name="employee three"},
                new Employee(){ Id=4,Department="HR",Name="employee four"},
            };
        }
    }
}
