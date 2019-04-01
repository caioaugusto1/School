using School_Project.Models.Login;
using System;

namespace School_Project.Entities
{
    public class Login
    {

        public Login()
        {

        }

        public Login(CreateLoginVM newLogin)
        {
            Id = Guid.NewGuid();
            UserName = newLogin.UserName;
            Password = newLogin.Password;
            if (newLogin.Type == Enums.LoginType.A)
                Type = "A";
            else
                Type = "S";

        }

        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Type { get; set; }
    }
}