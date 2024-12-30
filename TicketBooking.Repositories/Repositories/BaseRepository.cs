using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.DALs;
using TicketBooking.Repositories.IRepositories;

namespace TicketBooking.Repositories.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public readonly TicketBookingContext _context;
        public BaseRepository(TicketBookingContext context)
        {
            _context = context;
        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Find<T>(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(string id, T entity)
        {
            var currentEntity = _context.Find<T>(id);
            if (currentEntity != null) { 
                _context.Entry(currentEntity).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }
    }
}
