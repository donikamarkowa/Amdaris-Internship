using RepositoryPatternImplementation.Entities;
using RepositoryPatternImplementation.Interfaces;

namespace RepositoryPatternImplementation.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly List<T> _entities;
        public Repository(List<T> entities)
        {
            _entities = entities;
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Add(entity);
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }
    }
}
