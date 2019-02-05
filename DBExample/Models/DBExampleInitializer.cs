using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DBExample.Models
{
    public class DBExampleInitializer : DropCreateDatabaseAlways<DBExampleContext>
    {

        protected override void Seed(DBExampleContext context)
        {
            Person Billy = new Person {  FirstName="Billy", LastName="Bob" };

            Person Joe = new Person { FirstName = "Joe", LastName = "Regan" };

            Person Frank = new Person { FirstName = "Frank", LastName = "Sinatra" };
            context.People.Add(Billy);
            context.People.Add(Joe);
            context.People.Add(Frank);


            base.Seed(context);
        }
    }
}
