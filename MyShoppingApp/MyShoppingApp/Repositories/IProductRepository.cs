using MyShoppingApp.Models;

namespace MyShoppingApp.Repositories
{
    public interface IProductRepository
    {
        Product SaveProduct(Product product);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        bool UpdateProduct(Product product);    
        bool DeleteProduct(int id);

    }
}
