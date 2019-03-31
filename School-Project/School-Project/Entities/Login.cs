using System;

namespace School_Project.Entities
{
    public class Login
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Type { get; set; }

        //public Guid IdStudent { get; set; }

        //public virtual Student Student { get; set; }
    }
}