using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
       
        private readonly ILogger<ProductController> logger;
        private readonly IProductService productService;

        public ProductController(ILogger<ProductController> _logger, IProductService _productService)
        {
            logger = _logger;
            productService = _productService;

        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            return productService.GetProducts();
        }
    }
}
