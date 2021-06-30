using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtubedemonetcore.authorization
{
    public class tokenverify : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var headers = context.HttpContext.Request.Headers;
            var token = headers["tokenheader"];

            //now we will authorize
            // for timing, Lets assume header is not there
            if (token == "youtube.outtm.com")//false condition
            {
                // return ok,,,
            }
            else
            {
                // return unauthorize
                context.HttpContext.Response.StatusCode = 401;
                context.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Invalid Token";
                byte[] responsetext = Encoding.ASCII.GetBytes("INVALID RESPONSE BECAUSE OF WRONG TOKEN");
                context.HttpContext.Response.Body.WriteAsync(responsetext);
            }

        }
    }
}
