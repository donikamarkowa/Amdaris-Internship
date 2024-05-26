using ProjectStructure.Domain.Entities;
using ProjectStructure.Domain.Interfaces;

namespace ProjectStructure.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public IEnumerable<Student> GetAll() => _students;

        public Student GetById(Guid id) => _students.FirstOrDefault(s => s.Id == id);

        public void Add(Student student) => _students.Add(student);

        public void Update(Student student)
        {
            var existingStudent = GetById(student.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;
            }
        }

        public void Delete(Guid id)
        {
            var student = GetById(id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }
    }
}
