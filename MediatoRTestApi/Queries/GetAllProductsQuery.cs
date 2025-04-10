using MediatoRTestApi.Database;
using MediatR;

namespace MediatoRTestApi.Queries
{
    public sealed record GetAllProductsQuery : IRequest<List<Product>> { }
}
