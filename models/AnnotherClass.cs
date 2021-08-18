using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using youtubedemonetcore.configclasses;

namespace youtubedemonetcore.models
{
    public class AnnotherClass : IEmployee, IValueChecker
    // this class is also inherited....lets change here too
    {
        //let make this class have single object,, so that we can add methods to get count or to add employee
        List<Employee> emp;
        public IOptions<ConnectionStrings> Ioptionconfig;
        public ConnectionStrings ioptionssnapshotconfig;
        public AnnotherClass(IOptions<ConnectionStrings> ioptionconfig,
            IOptionsMonitor<ConnectionStrings> ioptionssnapshotconfig)
        {
            emp = new List<Employee>();
            Ioptionconfig = ioptionconfig;
            this.ioptionssnapshotconfig = ioptionssnapshotconfig.CurrentValue;
            ioptionssnapshotconfig.OnChange((newvalue) =>
            {
                this.ioptionssnapshotconfig = ioptionssnapshotconfig.CurrentValue;
                // whenever it changes,,,give me latest value,,from this above line...
            });
            // LETS RUN IT AND SEE
        }
        public object checkvalue()
        {
            // now inplace of using config file in API, we use it here
            // so that we can assure the effect of DI scopes on
            // IOptionsSnapshot// lets do it
            //var result = config["ConnectionStrings:dbconnectionstring"].ToString();
            var result = Ioptionconfig.Value.dbconnectionstring;
            // lets read new property value
            var result1 = ioptionssnapshotconfig.otherproperty;
            // note that we are focused to use CurrentValue, not value

            // lets run it,,,,,
            return (new { IOptions = result, IOptionsSnapshot = result1 });
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