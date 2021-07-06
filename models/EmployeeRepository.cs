using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using youtubedemonetcore.db;

namespace youtubedemonetcore.models
{
    //Here we are using the concept of inheritance,
    // If you are new to that, please visit 
    // youtube.outtm.com
    public class EmployeeRepository : IEmployee
    {
        private readonly dbOperations _db;
        public EmployeeRepository(dbOperations db)
        {
            this._db = db;
        }
        // this is other class from same interface,,,
        // but we are not using it,, so we can ignore it..
        public void AddEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public int EmployeeCount()
        {
            return _db.Employees.Count();
        }

        public List<Employee> GetEmployee()
        {
            // return all employees here
            return _db.Employees.ToList();
        }

        // lets run it
    }
}
