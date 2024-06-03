using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Interfaces;

namespace ProductManagement.Infrastructure.Data
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly ProductManagementDbContext _context;
        private readonly DbSet<T> _dbSet;

        public EfRepository(ProductManagementDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity) => _dbSet.Add(entity);

        public IEnumerable<T> GetAll() => _dbSet.ToList();

        public T GetById(int id) => _dbSet.Find(id);

        public void Remove(T entity) => _dbSet.Remove(entity);
    }
}
