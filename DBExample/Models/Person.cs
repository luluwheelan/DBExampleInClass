using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DBExample.Models
{
    public class Person
    {
        public virtual int PersonId { get; set; }

        [DisplayName("First Name")]
        [Required]
        public virtual string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public virtual string LastName { get; set; }
    }
}