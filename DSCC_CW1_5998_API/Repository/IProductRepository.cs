using DSCC_CW1_5998_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC_CW1_5998_API.Repository
{
    public interface IProductRepository
    {
        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productID);

        Product GetProductByID(int id);

        IEnumerable<Product> GetProducts();
    }
}
