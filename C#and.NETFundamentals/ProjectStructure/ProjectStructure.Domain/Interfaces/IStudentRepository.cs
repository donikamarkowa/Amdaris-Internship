using ProjectStructure.Domain.Entities;

namespace ProjectStructure.Domain.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(Guid id);
        void Add(Student student);
        void Update(Student student);
        void Delete(Guid id);
    }
}
