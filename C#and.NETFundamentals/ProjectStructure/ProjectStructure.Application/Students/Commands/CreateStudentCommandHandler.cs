using MediatR;
using ProjectStructure.Domain.Entities;
using ProjectStructure.Domain.Interfaces;

namespace ProjectStructure.Application.Students.Commands
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Id = request.Id,
                Name = request.Name,
                Age = request.Age
            };

            _studentRepository.Add(student);

            return Task.FromResult(Unit.Value);
        }
    }
}
