using School_Project.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace School_Project.Models.Login
{
    public class LoginBaseVM
    {
        public Guid Id { get; set; }

        [StringLength(255, ErrorMessage = "User Name", MinimumLength = 5)]
        public string UserName { get; set; }

        [Required]
        public LoginType Type { get; set; }
    }
}