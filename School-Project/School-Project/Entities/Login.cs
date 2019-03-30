using System;

namespace School_Project.Entities
{
    public class Login
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Type Type { get; set; }
    }

    public enum Type
    {
        Admin = 'A',
        Student = 'T'
    }
}