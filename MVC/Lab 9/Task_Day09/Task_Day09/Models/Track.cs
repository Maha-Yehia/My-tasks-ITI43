using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Day09.Models
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public List<Trainee> Trainees { get; set; }
    }
}
