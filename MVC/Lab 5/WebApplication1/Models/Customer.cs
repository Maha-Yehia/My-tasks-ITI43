using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public enum gender { Male , Female}
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required (ErrorMessage ="Please enter your name")]
        [MaxLength(30,ErrorMessage ="Please enter less than 30 letters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your gender")]
        [EnumDataType(typeof(gender))]
        public gender Gender { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your Email")]
        public string email { get; set; }
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression("^01[0 - 9]{9}$")]
        [Display(Name = "Phone Number")]
        public string phoneNum { get; set; }
        public List<Order> Orders { set; get; } = new List<Order>();

    }
}