using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.configclasses
{
    public class ConnectionStrings
    {
        // add all properties here same as that of config files3
        public string dbconnectionstring { get; set; }
        public string otherproperty { get; set; }
    }
}

// Lets make 2 properties here,,,to read 2 properties fom config file

// now we need same in config file too,, right,,
// lets add it in appsettings.json