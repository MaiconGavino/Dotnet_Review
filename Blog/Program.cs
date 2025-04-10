using Microsoft.Data.SqlClient;

namespace blog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void ReadUser()
        {
            using (var connection = new SqlConnection())
            {
                
            }
        }
    }
}