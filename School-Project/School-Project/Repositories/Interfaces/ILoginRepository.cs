using School_Project.Entities;

namespace School_Project.Repositories.Interfaces
{
    public interface ILoginRepository
    {
        Login SingIn(string username, string password);

        Login GetUserName(string username);
    }
}
