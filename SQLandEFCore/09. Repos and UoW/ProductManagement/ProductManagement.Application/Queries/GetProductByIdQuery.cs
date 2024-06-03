using MediatR;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id) => Id = id;
    }
}
