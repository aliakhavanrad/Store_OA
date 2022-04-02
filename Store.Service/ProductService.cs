using Store.Data.POCO;
using Store.Repo;
using System;
using System.Collections.Generic;

namespace Store.Service
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productRepository;
        public ProductService(IRepository<Product> repository)
        {
            productRepository = repository;
        }

        public void DeleteProduct(int id)
        {
            var product = productRepository.Get(id);
            productRepository.Delete(product);
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public void InsertProduct(Product product)
        {
            productRepository.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.Edit(product);
        }
    }
}
