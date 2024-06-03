using ProductManagement.Domain.Interfaces;

namespace ProductManagement.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductManagementDbContext _context;
        private readonly Dictionary<string, object> _repositories;

        public UnitOfWork(ProductManagementDbContext context)
        {
            _context = context;
            _repositories = new Dictionary<string, object>();
        }

        public IRepository<T> Repository<T>() where T : class
        {
            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(EfRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }

        public int Complete() => _context.SaveChanges();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
