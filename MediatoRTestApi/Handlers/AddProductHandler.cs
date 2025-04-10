using MediatoRTestApi.Commands;
using MediatoRTestApi.Database;
using MediatoRTestApi.Database.DataAccess;
using MediatR;

namespace MediatoRTestApi.Handlers
{
    public class AddProductHandler:IRequestHandler<AddProductCommand,Product>
    {

        private readonly ApplicationDbContext _context;
        public AddProductHandler(ApplicationDbContext context)
        {
              _context = context; 
        }


        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product { Name = request.Name };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;

        }
    } 


 }

