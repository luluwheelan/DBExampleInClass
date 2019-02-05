using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBExample.Models
{
    public class PersonList
    {
        public IEnumerable<Person> people { get; set; }
        public Person newGuy { get; set; }
    }
}