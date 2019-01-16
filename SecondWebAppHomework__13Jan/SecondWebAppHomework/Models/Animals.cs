using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAppHomework.Models
{
    public class Animals
    {

        [Required] // validation

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [MinLength(5)]
        public string NickName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }


        public int Id { get; set; }


    }
}
