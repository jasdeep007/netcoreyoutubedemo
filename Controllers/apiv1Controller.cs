using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using youtubedemonetcore.models;

namespace youtubedemonetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class apiv1Controller : ControllerBase
    {
        private readonly IEmployee emp;

        //lets import IEmployee by dependency injection
        public apiv1Controller(IEmployee emp)
        {
            this.emp = emp;
        }
        //lets create get api
        [HttpGet]
        [Route("[action]")]
        public IActionResult get()
        {
            // lets analyse calculation time also
            var starttime = DateTime.Now.ToString();
            var d1 = getEmployee();
            var d11 = getEmployee1();
            var d111 = getEmployee11();
            var d1111 = getEmployee111();
            var d11111 = getEmployee1111();
            var endtime = DateTime.Now.ToString();
            var data = new
            {
                starttime=starttime,
                endtime=endtime,
                d1 = d1,
                d11 = d11,
                d111 = d111,
                d1111 = d1111,
                d11111 = d11111,
            };
            return Ok(data);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> gettasks()
        {
            // lets analyse calculation time also
            var starttime = DateTime.Now.ToString();
            var d1 = Task.Run(()=>getEmployee()); // simple... code
            var d11 = Task.Run(() => getEmployee1());
            var d111 = Task.Run(() => getEmployee11());
            var d1111 = Task.Run(() => getEmployee111());
            var d11111 = Task.Run(() => getEmployee1111());

            // now we will wait for them all to execute
            await Task.WhenAll(d1, d11, d111);
            //now we are sure that all done here
            var endtime = DateTime.Now.ToString();
            // let see now,,, // expecting 30 seconds or not ??????
            //lets see
            var data = new
            {
                starttime = starttime,
                endtime = endtime,
                d1 = d1,
                d11 = d11,
                d111 = d111,
                d1111 = d1111,
                d11111 = d11111,
            };
            return Ok(data);
        }

        [NonAction]
        public List<Employee> getEmployee()
        {
            Thread.Sleep(10000);//10 seconds
            return emp.GetEmployee();
        }
        [NonAction]
        public List<Employee> getEmployee1()
        {
            Thread.Sleep(10000);//10 seconds
            return emp.GetEmployee();
        }
        [NonAction]
        public List<Employee> getEmployee11()
        {
            Thread.Sleep(10000);//10 seconds
            return emp.GetEmployee();
        }
        [NonAction]
        public List<Employee> getEmployee111()
        {
            Thread.Sleep(10000);//10 seconds
            return emp.GetEmployee();
        }
        [NonAction]
        public List<Employee> getEmployee1111()
        {
            Thread.Sleep(10000);//10 seconds
            return emp.GetEmployee();
        }
    }
}
