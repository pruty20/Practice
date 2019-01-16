using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAppHomework.Models
{
    public class Owner
    {

        public string FullName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }



    }
}
