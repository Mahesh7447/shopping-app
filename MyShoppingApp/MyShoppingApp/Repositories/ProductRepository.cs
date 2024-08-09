using Microsoft.EntityFrameworkCore;
using MyShoppingApp.Models;

namespace MyShoppingApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteProduct(int id)
        {
            var IsDeleted = false;
            var product = dbContext.Products.FirstOrDefault(product => product.ProductId == id);
            if(product != null)
            {
                dbContext.Products.Remove(product);
                dbContext.SaveChanges();
                IsDeleted=true;
            }
            return IsDeleted;
        }

        public List<Product> GetAllProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return dbContext.Products.FirstOrDefault(product => product.ProductId == id);
        }

        public Product SaveProduct(Product product)
        {
            if(product != null)
            {
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                return product; 
            }
            return null;
        }

        public bool UpdateProduct(Product product)
        {
            bool IsUpdated = false;
            if (product != null)
            {
                dbContext.Entry(product).State = EntityState.Modified;
                dbContext.SaveChanges();
                IsUpdated = true;

            }
            return IsUpdated;
        }
    }
}
