using BuilderCalculatorMVC.Domain.Models;
using System.Linq;
using BuilderCalculatorMVC.Domain.Interfaces;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class EntityRepository<T> : IEntityRepository<T> where T : class
    {
        private readonly Context _context;

        public EntityRepository(Context context)
        {
            _context = context;
        }
        public void AddNew(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(int id, T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
