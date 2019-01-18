using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAppHomework.Models
{
    public class Cat: Owner, IAnimals
    {
        [Required] // validation
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [MinLength(5)]
        [DisplayName("Nickname")]
        public string NickName { get; set; }

        [DisplayName("DOB")]
        public DateTime DateOfBirth { get; set; }

        
        public int Age { get; set; }

        public int Id { get; set; }

    }
}
