using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Trainee
    {
        [Key]
        public int TraineeID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Too long Name!!")]
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? MobileNo { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsGraduated { get; set; }
        public int TrackID { get; set; }
        public virtual Track? Track { get; set; }
    }
}
