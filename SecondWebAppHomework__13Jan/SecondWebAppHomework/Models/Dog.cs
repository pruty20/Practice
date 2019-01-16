using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAppHomework.Models
{
public class Dog
   {
        [Required] // validation
        [MinLength(3)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }


        public int Id { get; set; }
    }
}
