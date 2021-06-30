using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Text;

namespace youtubedemonetcore.authorization
{
    public class tokenverify : Attribute, IActionFilter
    {
        // lets build it

        private readonly IcheckToken token;
        public tokenverify(IcheckToken _token)
        {
            token = _token;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var headers = context.HttpContext.Request.Headers;
            var tokenvalue = headers["tokenheader"]; // same name...lets change it

            //now we will authorize
            // for timing, Lets assume header is not there
            // let see how we can check it in real time...
            // by creating one class and interface...
            //lets create it

            // but how .net core,,, now knows,,,this interface
            // IcheckToken belongs to class CheckToken
            // there can be other class to inherit same interface...
            // for this just one line..
            //lets add it


            if (token.checkToken(tokenvalue))//static rule
            {
                // return ok,,,
            }
            else
            {
                // return unauthorize
                context.HttpContext.Response.StatusCode = 401; // code is coming from here
                // reason is coming from below line
                context.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Invalid Token";

                // body message is coming from below 2 lines.,,, cool
                byte[] responsetext = Encoding.ASCII.GetBytes("INVALID RESPONSE BECAUSE OF WRONG TOKEN");
                context.HttpContext.Response.Body.WriteAsync(responsetext);
            }

        }
    }
}
