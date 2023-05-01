using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_1.Entities
{
    class Kitchen
    {
        [Key]
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
