using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using youtubedemonetcore.configclasses;

namespace youtubedemonetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class optionController : ControllerBase
    {
        private readonly IConfiguration config;
        public IOptions<ConnectionStrings> Ioptionconfig;
        public IOptionsSnapshot<ConnectionStrings> ioptionssnapshotconfig;

        //lets import IEmployee by dependency injection
        public optionController(IConfiguration _config,
            IOptions<ConnectionStrings> ioptionconfig,
            IOptionsSnapshot<ConnectionStrings> ioptionssnapshotconfig)
        {
            this.config = _config;
            Ioptionconfig = ioptionconfig;
            this.ioptionssnapshotconfig = ioptionssnapshotconfig;
        }

        // Its the same project I am working for this video series
        // Here we are in api controller,
        // lets make one method/action here
        [HttpGet]
        [Route("[action]")]
        public IActionResult readconfigfilevaluesimply()
        {
            //var result = config["ConnectionStrings:dbconnectionstring"].ToString();
            var result = Ioptionconfig.Value.dbconnectionstring;
            // lets read new property value
            var result1 = ioptionssnapshotconfig.Value.otherproperty;

            return Ok(new { IOptions = result, IOptionsSnapshot = result1});
        }
    }
}
