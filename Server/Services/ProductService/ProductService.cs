using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<IList<Product>>> GetProductsAsync()
    {
        var response = new ServiceResponse<IList<Product>>
        {
            Data = await _context.Products.ToListAsync()
        };

        return response;
    }
}
