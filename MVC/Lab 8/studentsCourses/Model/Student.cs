using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using static WebApplication1.Model.Student;

namespace WebApplication1.Model
{
    public enum Gender { Male, Female }

    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter Your Name"), MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public Gender gender { get; set; }

        [Required(ErrorMessage = "Please enter Your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter Your PhoneNum")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNum { get; set; }

        [Required(ErrorMessage = "Please enter Your Birthdate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public List<Course> CourseList { get; set; }
        
    }
}
