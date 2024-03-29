using Assignment.Entities;

namespace Assignment.DbContext
{
    public class DbContext<T> where T : Entity
    {
        private List<T> _values;
        public DbContext()
        {
            _values = new List<T>();
        }

        public List<T> Values => _values;
    }
}
