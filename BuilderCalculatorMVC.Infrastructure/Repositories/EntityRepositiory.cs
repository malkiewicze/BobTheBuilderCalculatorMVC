using BuilderCalculatorMVC.Domain.Models;
using BuilderCalculatorMVC.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderCalculatorMVC.Domain.Interfaces;

namespace BuilderCalculatorMVC.Infrastructure.Repositories
{
    public class EntityRepositiory<T> : IEntityRepository<T> where T : BaseEntity
    {
        private readonly Context _context;

        public EntityRepositiory(Context context)
        {
            _context = context;
        }
        public void AddNewEntity(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAllEntities()
        {
            return _context.Set<T>();
        }

        public T GetEntityById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void DeleteEntity(T entity)
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
