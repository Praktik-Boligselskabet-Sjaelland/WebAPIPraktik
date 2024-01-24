using WebApp.Models;

namespace WebApp.Services
{
    public interface IUserService
    {
        List<User> GetUsers();

        User GetUserFromId(int id);


    }
}
