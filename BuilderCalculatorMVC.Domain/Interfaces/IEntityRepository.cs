using BuilderCalculatorMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Interfaces
{
    public interface IEntityRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        int AddNew(T entity);
        void Delete(T entity);
        void Update(int id, T entity);
    }
}
