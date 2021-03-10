using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderCalculatorMVC.Domain.Interface
{
    public interface IEntityRepository<T>
    {
        IQueryable<T> GetAllEntities();
        T GetEntityById(int id);
        void AddNewEntity(T entity);
        void DeleteEntity(T entity);
        void Update(int id, T entity);
    }
}
