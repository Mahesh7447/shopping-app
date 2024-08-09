using MyShoppingApp.Models;

namespace MyShoppingApp.Services
{
    public interface IProductService
    {
        Product SaveProduct(Product product);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}
