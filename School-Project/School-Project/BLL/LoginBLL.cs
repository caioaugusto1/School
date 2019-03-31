using AutoMapper;
using School_Project.Entities;
using School_Project.Filters;
using School_Project.Models.Login;
using School_Project.Repositories;
using System;
using System.Text;

namespace School_Project.BLL
{
    public class LoginBLL
    {
        private readonly LoginRepository _loginRepository;

        public LoginBLL(LoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public Login SingIn(string username, string password)
        {
            string criptoPassword = CriptoMd5(password);

            Login login = _loginRepository.SingIn(username, criptoPassword);

            if (login == null)
                throw new Exception("Incorret Username or password");

            SessionManager.AccountLogin = login;
            System.Web.Security.FormsAuthentication.SetAuthCookie(login.UserName, true);
            
            return login;
        }

        public Login CreateLogin(CreateLoginVM newLogin)
        {
            Login validationLogin = _loginRepository.GetUserName(newLogin.UserName);

            if (validationLogin != null)
                return null;

            Login login = Mapper.Map<CreateLoginVM, Login>(newLogin);

            login.Password = CriptoMd5(login.Password);

            _loginRepository.Insert(login);

            return new Login();
        }

        private string CriptoMd5(string password)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            return BitConverter.ToString(s).ToLower();
        }
    }
}