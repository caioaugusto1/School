using System;
using System.ComponentModel.DataAnnotations;

namespace School_Project.ViewModels
{
    public class StudentVM
    {
        [Required(ErrorMessage = "First Name")]
        [StringLength(40, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname")]
        [StringLength(40, MinimumLength = 2)]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Gender")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Gender")]
        [StringLength(40, MinimumLength = 2)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Gender")]
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