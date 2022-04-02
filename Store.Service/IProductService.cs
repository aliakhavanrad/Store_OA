using Store.Data.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
