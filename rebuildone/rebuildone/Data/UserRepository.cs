using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rebuildone.Models;

namespace rebuildone.Data
{
    public class UserRepository : IUserRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUser()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAll()
        {
            throw new NotImplementedException();
        }
    }
}
