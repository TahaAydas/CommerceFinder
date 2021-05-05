using CommerceFinder.Business.Abstract;
using CommerceFinder.DataAccess.Abstract;
using CommerceFinder.DataAccess.Concrete;
using CommerceFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceFinder.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }
        public Products CreateProduct(Products product)
        {
            return _productRepository.CreateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public List<Products> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Products GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public Products UpdateProduct(Products product)
        {
            return _productRepository.UpdateProduct(product);
        }
    }
}
