namespace WebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public List<PowerUse>? PowerUsage { get; set; }


        public User(int Id, string name, string email)
        {

        }

        public User(int Id, string name, string email, string password)
        {

        }
    }
}
