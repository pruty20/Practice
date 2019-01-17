using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAppHomework.Models
{
    interface IAnimals
    {

        [Required] // validation

        string FirstName { get; set; }

        string LastName { get; set; }

        [MinLength(5)]
        string NickName { get; set; }

        DateTime DateOfBirth { get; set; }

        int Age { get; set; }

        int Id { get; set; }


    }
}
