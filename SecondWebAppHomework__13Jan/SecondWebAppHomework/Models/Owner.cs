using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAppHomework.Models
{
    public class Owner
    {
        [DisplayName ("Owner Name")]
        public string FullName { get; set; }

        [EmailAddress]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }



    }
}
