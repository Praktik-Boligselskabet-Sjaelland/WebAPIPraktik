using Microsoft.Data.SqlClient;
using WebApp.Models;
using WebApp.Services.Interfaces;

namespace WebApp.Services.UserService
{
    public class UserService : Connection, IUserService
    {


        private string queryString = "select * from [User]";

        public UserService(IConfiguration configuration) : base(configuration) 
        {

        }

        public UserService(string connectionString) : base(connectionString)
        {

        }


        public User GetUserFromId(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    int User_Id = reader.GetInt32(0);
                    string User_Name = reader.GetString(1);
                    string User_Email = reader.GetString(2);

                    User user = new User(User_Id, User_Name, User_Email);
                    users.Add(user);
                }
            }

            return users;

        }
    }
}
