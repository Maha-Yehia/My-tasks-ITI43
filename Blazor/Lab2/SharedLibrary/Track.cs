using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Track
    {
        [Key]
        public int TrackID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Too long Name!!")]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Trainee> Trainees { get; set;}
    }
}
