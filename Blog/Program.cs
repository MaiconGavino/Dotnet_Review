using blog.DataContext;
using blog.Models;
using blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace blog
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CreateUser();
            ReadUser();
            ReadRoles();
        }

        public static void ReadUser()
        {
            var repository = new UserRepository(new DataBaseConfig());
            var users = repository.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
        public static void ReadRoles()
        {
            var repository = new RoleRepository(new DataBaseConfig());
            var roles = repository.GetAll();
            foreach (var role in roles)
            {
                Console.WriteLine(role.Name);
            }
        }

        public static void CreateUser()
        {
            var dbConfig = new DataBaseConfig();
            var user = new User()
            {
                Name = "admin",
                Email = "admin@admin.com",
                Bio = "Minha experiencai em dat",
                Image = "https://dams",
                PasswordHash = "#ddsf",
                Slug = "/admin"
            };
            using (var connection = dbConfig.GetConnection())
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastrado com sucesso!");
            }
        }
    }
}