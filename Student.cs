
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "GPA is required.")]
        public double GPA { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; } = null;

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get;set; } = null;
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; } = null;

        [Required(ErrorMessage = "Profile image is required.")]
        public string? ImageFilebase64 { get; set; } = null;
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; } = null;
        [Required(ErrorMessage = "Date of birth is required.")]
        public DateOnly DateOfBirth { get; set; }

        [NotMapped]
        public string FullNmae => $"{FirstName} {LastName}";

        public Student Clone()
        {
            return new Student
            {
                Id = this.Id,
                GPA = this.GPA,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Gender = this.Gender,
                ImageFilebase64 = this.ImageFilebase64,
                Email = this.Email,
                DateOfBirth = this.DateOfBirth
            };
        }
    }
}
