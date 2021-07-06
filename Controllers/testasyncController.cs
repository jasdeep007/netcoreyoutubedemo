using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace youtubedemonetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testasyncController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public string testapi()
        {
            //lets run it,, its a simple API
            return "youtube.outtm.com";
            // cool now we make api that has methods that execute long time
        }


        //[HttpGet]
        //[Route("[action]")]
        //public async Task<IActionResult> longrun()
        //{
        //    // lets run both
        //    var starttime = DateTime.Now.ToString();
        //    var t1 = executelong(); // simple syntax
        //    var t2 = executelongafter10seconds(); // takes 10 seconds,, right??
        //    var t3 = executelong1after10seconds();

        //    var t4 = e1xecutelong1after10seconds();
        //    var t5 = e2xecutelong1after10seconds();
        //    var t6 = e3xecutelong1after10seconds();
        //    var t7 = e4xecutelong1after10seconds();
        //    var endtime = DateTime.Now.ToString();

        //    var result = new
        //    {
        //        starttime=starttime,
        //        endtime=endtime,
        //        t1=t1,
        //        t2=t2,
        //        t3=t3,
        //        t4=t4,
        //        t5=t5,
        //        t6=t6,
        //        t7=t7
        //    };
        //    // so total without async is 80 seconds,,,
        //    // and with async its just 30 seconds... lets see



        //    // lets see the output
        //    return Ok(result);
        //}
        public string executelong()
        {
            Thread.Sleep(30000);// add 30 seconds wait
            return "youtube.outtm.com after 30 seconds.";
        }
        public string executelongafter10seconds()
        {
            Thread.Sleep(10000);// add 10 seconds wait
            return "bestcourses.outtm.com after 10 seconds.";
        }
        public string executelong1after10seconds()
        {
            Thread.Sleep(10000);// add 10 seconds wait
            return "bestcourses.outtm.com (1) after 10 seconds.";
        }
        public string e1xecutelong1after10seconds()
        {
            Thread.Sleep(10000);// add 10 seconds wait
            return "bestcourses.outtm.com (1) after 10 seconds.";
        }
        public string e2xecutelong1after10seconds()
        {
            Thread.Sleep(10000);// add 10 seconds wait
            return "bestcourses.outtm.com (1) after 10 seconds.";
        }
        public string e3xecutelong1after10seconds()
        {
            Thread.Sleep(10000);// add 10 seconds wait
            return "bestcourses.outtm.com (1) after 10 seconds.";
        }
        public string e4xecutelong1after10seconds()
        {
            Thread.Sleep(10000);// add 10 seconds wait
            return "bestcourses.outtm.com (1) after 10 seconds.";
        }
    }
}
