using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using youtubedemonetcore.models;

namespace youtubedemonetcore.db
{
 
    // its a simple class
    //lets inherit it from DbContext
    public class dbOperations : DbContext
    {
        // next we need to set its options... 
        // that we set in the constructor
        // lets do it


        public dbOperations(DbContextOptions<dbOperations> options)
            : base(options)
        {
            // we pass current class to its options and pass
            // those options to its base class
            // you can say its required for its working..
        }

        // next we will create table (DbSet) of our class

        public DbSet<Employee> Employees { get; set; }


        // simple..isn't it....

        // now lets build it

        // now next, we need to add it to services
        // to let .netcore know that we are using dbcontext
        // and this class as db context and also connection string
        // lets do it





    }
}
