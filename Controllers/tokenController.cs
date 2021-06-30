using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using youtubedemonetcore.authorization;

namespace youtubedemonetcore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class tokenController : ControllerBase
    {
        //now lets put authorization

        //lets get httpget api
        [HttpGet]
        [tokenverify] // use as a filter,,,,so easy ,, right ????
        public string tokenrequest()
        {
            return "youtube.outtm.com offers free learning";
        }
        //lets run it

    }
}
