using Microsoft.Data.SqlClient;
using WebApp.Models;
using WebApp.Services.Interfaces;

namespace WebApp.Services.PowerUseService
{
    public class PowerUseService : Connection, IPowerUseService
    {

        private string queryStringFromUserId = "select * from PowerUse where User_Id = @USER_ID";
        private string queryStringFromId = "select * from PowerUse where Id = @ID";
        private string insertSql = "insert into PowerUse Values (@ID, @TIMEPERIOD, @POWER_USED, @POWER_PRODUCED, @USER_ID)";
        private string queryString = "select * from PowerUse";

        public PowerUseService(IConfiguration configuration) : base(configuration)
        {
        }

        public PowerUseService(string connectionString) : base(connectionString)
        {

        }


        public bool CreatePowerUse(PowerUse powerUse)
        {
            throw new NotImplementedException();
        }

        public PowerUse GetPowerUseFromId(int Id)
        {
            PowerUse powerUse = new PowerUse();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryStringFromId, connection);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read()) 
                {
                    DateTime TimePeriod = reader.GetDateTime(1);
                    int Power_Used = reader.GetInt32(2);
                    int Power_Produced = reader.GetInt32(3);
                    PowerUse power_use = new PowerUse(TimePeriod, Power_Used, Power_Produced);
                }
            }
            return powerUse;
        }

        public List<PowerUse> GetPowerUseFromUserId(int userId)
        {
            List<PowerUse> powerUseList = new List<PowerUse>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryStringFromUserId, connection);
                command.Parameters.AddWithValue("@USER_ID", userId);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime TimePeriod = reader.GetDateTime(1);
                    int Power_Used = reader.GetInt32(2);
                    int Power_Produced = reader.GetInt32(3);
                    PowerUse power_use = new PowerUse(TimePeriod, Power_Used, Power_Produced);
                    powerUseList.Add(power_use);
                }
            }
            return powerUseList;
        }
    }
}
