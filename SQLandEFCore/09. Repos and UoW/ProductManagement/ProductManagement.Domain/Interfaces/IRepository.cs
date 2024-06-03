using System.Collections.Generic;

namespace ProductManagement.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Remove(T entity);
    }
}
