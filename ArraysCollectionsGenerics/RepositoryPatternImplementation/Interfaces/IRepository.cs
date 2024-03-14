using RepositoryPatternImplementation.Entities;

namespace RepositoryPatternImplementation.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        T GetById(int id);

        void Add(T entity);

        void Delete(T entity);
    }
}
