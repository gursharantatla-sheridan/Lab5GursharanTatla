using System.ComponentModel.DataAnnotations;

namespace Lab5GursharanTatla.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please provide your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide your last name")]
        public string LastName { get; set; }
        public string? Email { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
