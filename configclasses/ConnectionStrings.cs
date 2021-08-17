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
    }
}

// now we create one class same as that of config section...
// lets tell .netcore about this... as currently its a simple class
// right...????
// to tell .net core we need to register it as a service,,,
// lets do that....
