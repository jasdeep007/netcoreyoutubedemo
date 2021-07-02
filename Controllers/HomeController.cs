using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using youtubedemonetcore.models;

namespace youtubedemonetcore.Controllers
{
    public class HomeController : Controller
    {

        //contructor
        // here we are importing this interface
        // by the concept of dependency injection
        // its a concept where we can inject only required services in constructor
        // we will discuss it in detail in future video

        private readonly IEmployee emp;// emp we will use in this class
        public HomeController(IEmployee _emp)
        {
            this.emp = _emp;
        }
        public IActionResult Index()
        {
            TempData["Data"] = JsonConvert.SerializeObject(emp.GetEmployee());
            
            // now directly other controller will open
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }
    }
}
