namespace WebApp.Services
{
    public abstract class Connection
    {
        protected string _connectionString;

        public IConfiguration Configuration { get; }

        public Connection(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:BOSJ"];
        }

        public Connection(string connectionString) 
        {
            Configuration = null;
            this._connectionString = connectionString;
        }

    }

}
