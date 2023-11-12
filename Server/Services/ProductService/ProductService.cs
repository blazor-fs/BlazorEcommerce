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

    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
    {
        var response = new ServiceResponse<Product>();
        Product product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            response.Success = false;
            response.Message = "Sorry, but this product does not exist.";
        }
        else
        {
            response.Data = product;
        }

        return response;
    }
}
