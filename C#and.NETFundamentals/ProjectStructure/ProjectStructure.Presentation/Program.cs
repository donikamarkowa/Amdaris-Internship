using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectStructure.Application.Students.Commands;
using ProjectStructure.Application.Students.Queries;
using ProjectStructure.Domain.Interfaces;
using ProjectStructure.Infrastructure.Repositories;

namespace CleanArchitectureExample.Presentation
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var mediator = host.Services.GetRequiredService<IMediator>();

            // Add a new student
            var studentId = Guid.NewGuid();
            await mediator.Send(new CreateStudentCommand { Id = studentId, Name = "John Doe", Age = 20 });

            // Get all students
            var students = await mediator.Send(new GetStudentsQuery());
            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}, Age: {student.Age}");
            }
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddMediatR(typeof(GetStudentsQueryHandler).Assembly)
                            .AddSingleton<IStudentRepository, StudentRepository>());
    }
}
