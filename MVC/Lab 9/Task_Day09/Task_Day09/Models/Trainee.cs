using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Day09.Models
{
    public class Trainee
    {
        [Key]
        public int TraineeId { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Name Must be only characters")]
        [Display(Name = "Student Name")]
        public string TraineeName { get; set; }
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "You have to enter your email!")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }
        [Required(ErrorMessage = "You have to enter your phone number!")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        [Column("BirthDate", TypeName = "date")]
        public DateTime Birthdate { get; set; }
        [ForeignKey("TrackID")]
        public Track TrTrack { get; set; }
        [Required]
        public int TrackID { get; set; }

        [Required]
        public int CourseID { get; set; }

        [ForeignKey("CourseID")]
        public Course course { get; set; }
    }
    public enum Gender { Male, Female }

}
