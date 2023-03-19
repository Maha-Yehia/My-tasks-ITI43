using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task2.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Please enter the cleint name")]
        [MaxLength(30) , DataType(DataType.Text)]
        public string ClientName { get; set; }
        [Required(ErrorMessage ="Please enter your password")]
        [ DataType(DataType.Password) , MinLength(6 , ErrorMessage ="Please enter at least 6 digits")]

        public string Password { get; set; }

        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your mobile number")]
        [DataType(DataType.PhoneNumber)]

        public string Mobile { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email")]

        public string Email { get; set; }

    }
}