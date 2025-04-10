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

        public void Create(User user)
        {
            user.Id = 0;
            using var connection = _dbConfig.GetConnection();
            connection.Insert<User>(user);
        }

        public void Update(User user)
        {
            if (user.Id != 0)
            {
                using var connection = _dbConfig.GetConnection();
                connection.Update<User>(user);
            }
        }

        public void Delete(int id)
        {
            if (id != 0)
            {
                return;
            }
            var connection = _dbConfig.GetConnection();
            var user = connection.Get<User>(id);
            connection.Delete<User>(user);
        }

        public void Delete(User user)
        {
            if (user.Id != 0)
            {
                var connection = _dbConfig.GetConnection();
                connection.Delete<User>(user);
            }
        }
    }
}