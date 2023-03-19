using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        public enum gender { Male , Female}

        [Key]
        public int empID { get; set; }
        [Required(ErrorMessage ="Please enter you name") ]
        [MaxLength(30,ErrorMessage ="Too long name!") , DataType( DataType.Text ,ErrorMessage ="Please enter letters only")]
        public string Name { get; set; }
        [Compare("Name" , ErrorMessage ="not matched username!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter you password")]
       // [MinLength(5, ErrorMessage = "Password have to be within range 5 to 10"), MaxLength(10, ErrorMessage = "Password have to be within range 5 to 10")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Please enter your gender") , EnumDataType(typeof(gender))]
        public gender Gender { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [ DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime joinDate { get; set; }
        [DataType(DataType.EmailAddress), Required(ErrorMessage = "Please enter you email")]
        public string email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(13)]
 
        public string phoneNum { get; set; }    


    }
}