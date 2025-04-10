using MediatoRTestApi.Database;
using MediatoRTestApi.Database.DataAccess;
using MediatoRTestApi.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatoRTestApi.Handlers
{
    public sealed record GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllProductsHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync();
        }
    }
    
    
}
