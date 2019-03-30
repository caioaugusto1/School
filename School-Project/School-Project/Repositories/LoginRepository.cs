using School_Project.Context;
using School_Project.Entities;
using School_Project.Repositories.Interfaces;
using System.Linq;

namespace School_Project.Repositories
{
    public class LoginRepository : RepositoryBase<Login>, ILoginRepository
    {
        public LoginRepository(SchoolDBContext schoolDBContext) : base(schoolDBContext)
        {

        }

        public Login SingIn(string username, string password)
        {
            return _schoolDBContext.Login.FirstOrDefault(l => l.UserName == username && l.Password == password);
        }

        public Login GetUserName(string username)
        {
            return _schoolDBContext.Login.FirstOrDefault(l => l.UserName == username);
        }
    }
}