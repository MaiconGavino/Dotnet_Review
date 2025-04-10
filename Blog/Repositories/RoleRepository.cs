using blog.DataContext;
using blog.Models;
using Dapper.Contrib.Extensions;

namespace blog.Repositories
{
    public class RoleRepository
    {
        private readonly DataBaseConfig _dbConfig;

        public RoleRepository(DataBaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public IEnumerable<Role> GetAll()
        {
            using (var connection = _dbConfig.GetConnection())
            {
                return connection.GetAll<Role>();
            }
        }

        public Role Get(int id)
        {
            using var connection = _dbConfig.GetConnection();
            return connection.Get<Role>(id);
        }
        public void Create(Role role)
        {
            role.Id = 0;
            using var connection = _dbConfig.GetConnection();
            connection.Insert<Role>(role);
        }

        public void Update(Role role)
        {
            if (role.Id != 0)
            {
                using var connection = _dbConfig.GetConnection();
                connection.Update<Role>(role);
            }
        }

        public void Delete(int id)
        {
            if (id != 0)
            {
                return;
            }
            var connection = _dbConfig.GetConnection();
            var role = connection.Get<Role>(id);
            connection.Delete<Role>(role);
        }

        public void Delete(Role role)
        {
            if (role.Id != 0)
            {
                var connection = _dbConfig.GetConnection();
                connection.Delete<Role>(role);
            }
        }
    }
}