using Moq;
using NUnit.Framework;
using Store.Data.POCO;
using Store.Repo;
using Store.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Tests
{
    public class ProductServiceTest
    {
        ProductService productService;
        Mock<IRepository<Product>> productRepositoryMock;

        [SetUp]
        public void Setup()
        {
            productRepositoryMock = new Mock<IRepository<Product>>();
            
            productRepositoryMock.Setup(x => x.GetAll()).Returns(
               new List<Product> { new Product { ID = 20, ModelName = "Test" }
               });

            

            productService = new ProductService(productRepositoryMock.Object);


        }


        [Test]
        public void GetProducts_Works()
        {
            //Arrange
            
            //Act
            var products = productService.GetProducts();


            //Assert
            Assert.That(products, Is.Not.Null);
        }
    }
}
