using DotNetEnv;
using Microsoft.Data.SqlClient;

namespace blog.DataContext
{
    public class DataBaseConfig
    {
        public string Server { get; private set; }
        public string User { get; private set; }
        public string Database { get; private set; }
        public string Password { get; private set; }

        public DataBaseConfig()
        {
            Env.Load("/Users/maicongavino/dev/dotnet/DotnetReview/Blog/.env");
            Server = Environment.GetEnvironmentVariable("DB_SERVER");
            User = Environment.GetEnvironmentVariable("DB_USER");
            Database = Environment.GetEnvironmentVariable("DB_NAME");
            Password = Environment.GetEnvironmentVariable("DB_PASSWORD");
        }

        public SqlConnection GetConnection()
        {
            string connection = $"Server={Server};Database={Database};User Id={User};Password={Password};TrustServerCertificate=True;";
            return new SqlConnection(connection);
        }
    }
}