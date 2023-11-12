namespace BlazorEcommerce.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<IList<Product>>> GetProductsAsync();
    Task<ServiceResponse<Product>> GetProductByIdAsync(int id);
}
