using System;
using System.ComponentModel.DataAnnotations;

namespace School_Project.Models
{
    public class StudentVM
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First Name")]
        [StringLength(40, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname")]
        [StringLength(40, MinimumLength = 2)]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Gender")]
        public char Gender { get; set; }

        [Required(ErrorMessage = "DOB")]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Address1")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }
    }

    public enum Gender
    {
        Male = 'M',
        Famale = 'F'
    }
}