using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Repositories.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Create(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
        T Update(string id, T entity);

    }
}
