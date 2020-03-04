using DSCC_CW1_5998_API.DbContexts;
using DSCC_CW1_5998_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC_CW1_5998_API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteProduct(int productID)
        {
            var product = _dbContext.Products.Find(productID);
            _dbContext.Products.Remove(product);
            Save();
        }

        public Product GetProductByID(int productID)
        {
            var prod = _dbContext.Products.Find(productID);
            return prod;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products;
        }
        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}