using blog.DataContext;
using blog.Models;
using Dapper.Contrib.Extensions;

namespace blog.Repositories
{
    public class UserRepository
    {
        private readonly DataBaseConfig _dbConfig;

        public UserRepository(DataBaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public IEnumerable<User> GetAll()
        {
            using (var connection = _dbConfig.GetConnection())
            {
                return connection.GetAll<User>();
            }
        }

        public User Get(int id)
        {
            using var connection = _dbConfig.GetConnection();
            return connection.Get<User>(id);
        }
    }
}