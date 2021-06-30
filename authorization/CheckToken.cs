using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.authorization
{
    public class CheckToken : IcheckToken
    {
        // simple logic right.....
        // // lets use it
        public bool checkToken(string headervalue)
        {
           if(headervalue == "youtube.outtm.com")
            {
                return true;
            }
            return false;
        }
    }
}
