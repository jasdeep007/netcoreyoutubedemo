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


        // lets convert it into task to create/ add employee
        // its inherited from interface,,lets change there too
        // this is for EF Core
        public async Task<Employee> AddEmployee(Employee emp)
        {
            // saving with tasks are performant
            // let see overall flow now
            _db.Employees.Add(emp);
            await _db.SaveChangesAsync();
            return emp;
        }

        public async Task<int> DeleteEmployee(int id)
        {
            _db.Employees.Remove(_db.Employees.First(x=>x.Id==id));
            await _db.SaveChangesAsync();
            return id;
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
