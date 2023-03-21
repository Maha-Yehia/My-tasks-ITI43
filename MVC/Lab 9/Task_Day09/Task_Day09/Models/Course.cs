using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Day09.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [StringLength(50)]
        public string Topic { get; set; }
        [Required]
        public int Grade { get; set; }
        public List<Trainee> Trainees { get; set; }
    }
}
