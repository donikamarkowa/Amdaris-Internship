using MediatR;
using ProjectStructure.Domain.Entities;

namespace ProjectStructure.Application.Students.Queries
{
    public class GetStudentsQuery : IRequest<IEnumerable<Student>> 
    {
    }
}
