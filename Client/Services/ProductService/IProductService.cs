using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.ProductService;

public interface IProductService
{
    IList<Product> Products { get; set; }
    Task GetProducts();
}
