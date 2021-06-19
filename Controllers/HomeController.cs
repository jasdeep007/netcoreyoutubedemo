using Microsoft.AspNetCore.Mvc;
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
            // return data with 200 status code
            // lets run the code and see the output
            // Error occured... WHY ??????
            //
            return Json(emp.GetEmployee());
        }
    }
}
