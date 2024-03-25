using Assignment.Entities;

namespace Assignment.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        int SaveSpeaker(T speaker);
    }
}