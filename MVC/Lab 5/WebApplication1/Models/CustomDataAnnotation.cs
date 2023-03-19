using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    
    public class CustomDataAnnotation : ValidationAttribute
    {
        int TotalPrice;
        public CustomDataAnnotation(int totalPrice)
        {
            TotalPrice = (int)totalPrice;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return false;
            else
            {
                if (value is decimal)
                {
                    decimal totalOrder = (decimal)value;
                    if (totalOrder > TotalPrice)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = $"Total Price is not valid!";
                        return false;
                    }
                }
                else { return false; }
            }

        }

    }
}