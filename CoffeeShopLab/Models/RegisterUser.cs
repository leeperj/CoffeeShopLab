using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopLab.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter valid email address")]
        public string UserEmail { get; set;}
        [Required(ErrorMessage = "Please enter a password")]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage ="Please enter a user name")]
        public string UserName { get; set; }


    
    }
}
