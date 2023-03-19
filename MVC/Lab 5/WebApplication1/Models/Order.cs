using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required (ErrorMessage ="Please enter the date of the order")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }
        [DataType(DataType.Currency)]
        [Required (ErrorMessage ="Please enter the total price")]
        [CustomDataAnnotation(500)]
        public decimal TotalPrice { get; set; }
        [ForeignKey("Customer")]
        [Display(Name ="Customer name")]
        public int CustID { get; set; }
        public Customer Customer { get; set; }
    }
}