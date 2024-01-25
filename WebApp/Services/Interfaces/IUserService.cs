using WebApp.Models;

namespace WebApp.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetUsers();

        User GetUserFromId(int id);


    }
}
