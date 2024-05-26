using MediatR;
using ProjectStructure.Domain.Entities;
using ProjectStructure.Domain.Interfaces;

namespace ProjectStructure.Application.Students.Queries
{
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, IEnumerable<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentsQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<IEnumerable<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = _studentRepository.GetAll();
            return Task.FromResult(students);
        }
    }
}
