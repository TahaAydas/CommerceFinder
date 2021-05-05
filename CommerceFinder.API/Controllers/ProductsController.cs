using CommerceFinder.Entities;
using Microsoft.AspNetCore.Http;
using CommerceFinder.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceFinder.Business.Concrete;

namespace CommerceFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController()
        {
            _productService = new ProductManager();
        }

        [HttpGet]
        public List<Products> Get()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Products Get(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost]
        public Products Post([FromBody] Products products)
        {
            return _productService.CreateProduct(products);
        }

        [HttpPut]
        public Products Put([FromBody] Products product)
        {
            return _productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
