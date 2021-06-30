using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.authorization
{
    public interface IcheckToken
    {
        //interfaces contains only method name
        //if you are new to interfaces,
        // please visit youtube.outtm.com
        public bool checkToken(string headervalue);

        //lets make one class to implement this interface

    }
}
