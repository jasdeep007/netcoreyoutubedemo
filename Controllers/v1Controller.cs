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
    public class v1Controller : ControllerBase
    {
        private readonly IEmployee emp;

        public v1Controller(IEmployee emp)
        {
            this.emp = emp;
        }

        [HttpGet]
        [Route("[action]/{i}")]
        public async Task<IActionResult> get(int i)
        {
            var startTime = DateTime.Now.ToString();
            var t1 = Task.Run(() => getdata1());
            var t11 = Task.Run(() => getdata11(i));
            var t111 = Task.Run(() => getdata111(i));

            await Task.WhenAll(t1, t11, t111);
            var endTime = DateTime.Now.ToString();
            var data = new
            {
                startTime = startTime,
                endtime = endTime,
                ivalue = i,
                d1 = t1.Status == TaskStatus.RanToCompletion ? t1.Result : null,
                d2 = t1.Status == TaskStatus.RanToCompletion ? t1.Result : null,
                d3 = t1.Status == TaskStatus.RanToCompletion ? t1.Result : null,
            };

            return Ok(data);

        }
        [HttpGet]
        [Route("[action]/{i}")]
        public IActionResult get1(int i)
        {
            var startTime = DateTime.Now.ToString();
            var d1 = getdata1();
            var d2 = getdata11(i);
            var d3 = getdata111(i);
            var endTime = DateTime.Now.ToString();
            var data = new
            {
                startTime = startTime,
                endtime = endTime,
                ivalue = i,
                d1 = d1,
                d2 = d2,
                d3 = d3,
            };

            return Ok(data);

        }
        [NonAction]
        public object getdata1()
        {
            return new { threadID = Thread.CurrentThread.ManagedThreadId.ToString(), data = emp.GetEmployee() };
        }
        [NonAction]
        public object getdata11(int i)
        {
            if (i == 1) Thread.Sleep(10000);
            return new { threadID = Thread.CurrentThread.ManagedThreadId.ToString(), data = emp.GetEmployee() };
        }
        [NonAction]
        public object getdata111(int ii)
        {
            if (ii == 1) Thread.Sleep(10000);
            
            return new { threadID = Thread.CurrentThread.ManagedThreadId.ToString(), data = emp.GetEmployee() };
        }

    }
}
