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
        //lets add one basic create method,, simple get request to create
        // will make good one in future with proper post requests

        public IActionResult createEmployee()
        {
            // from here it will create it,, then create new request to index
            // NOTE:: this is one request and to index then other request////
            emp.AddEmployee(new Employee() { Id = 1, Department = "HR", Name = "employee name added from class method" });
            TempData["Data"] = JsonConvert.SerializeObject(emp.GetEmployee());
            return View("index");
        }


        public IActionResult Chat()
        {
            return View();
        }
    }
}
