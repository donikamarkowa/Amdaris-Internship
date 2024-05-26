using MediatR;

namespace ProjectStructure.Application.Students.Commands
{
    public class CreateStudentCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
