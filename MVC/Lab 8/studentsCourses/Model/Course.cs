using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Please enter the topic"), MaxLength(20)]
        public string Topic { get; set; }

        [Required(ErrorMessage = "Please enter the grade")]
        public int CourseGrade { get; set; }
        [ForeignKey(nameof(Student))]
        public int StdID { get; set; }
   
        Student student { get; set; }
    }
}
