using MyShoppingApp.Models;
using MyShoppingApp.Repositories;

namespace MyShoppingApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public bool DeleteProduct(int id)
        {
            return productRepository.DeleteProduct(id); 
        }

        public List<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return productRepository.GetProductById(id);    
        }

        public Product SaveProduct(Product product)
        {
            return productRepository.SaveProduct(product);  
        }

        public bool UpdateProduct(Product product)
        {
            return productRepository.UpdateProduct(product);
        }
    }
}
