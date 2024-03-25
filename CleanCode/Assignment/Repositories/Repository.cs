using Assignment.DbContext;
using Assignment.Entities;

namespace Assignment.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DbContext<T> _dbContext;
        public Repository(DbContext<T> dbContext)
        {
            _dbContext = dbContext;
        }
        public int SaveSpeaker(T speaker)
        {
            if (speaker == null)
            {
                throw new ArgumentNullException(nameof(speaker));
            }

            int randomId = new Random().Next(); 
            speaker.Id = randomId;

            return randomId;
        }
    }
}
