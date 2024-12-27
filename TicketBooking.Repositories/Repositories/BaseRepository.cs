using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Repositories.IRepositories;

namespace TicketBooking.Repositories.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public void Create(T entity)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(string id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
