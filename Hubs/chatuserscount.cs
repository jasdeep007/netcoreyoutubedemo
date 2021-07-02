using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtubedemonetcore.Hubs
{
    public class chatuserscount : Iusers
    {
        public int users=0;
        public int adduser()
        {
            users = users + 1;
            return users;
        }
        public int removeuser()
        {
            users = users - 1;
            return users;
        }
    }
}
