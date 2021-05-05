using CommerceFinder.DataAccess.Abstract;
using CommerceFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommerceFinder.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Products CreateProduct(Products product)
        {
            using (var productDbContext = new ProductDbContext())
            {
                productDbContext.Products.Add(product);
                productDbContext.SaveChanges();
                return product;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var productDbContext = new ProductDbContext())
            {

                var deletedProduct = GetProductById(id);
                productDbContext.Products.Remove(deletedProduct);
                productDbContext.SaveChanges();
            }
        }

        public List<Products> GetAllProducts()
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.ToList();
            }
        }

        public Products GetProductById(int id)
        {
            using (var productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.Find(id);
            }
        }

        public Products UpdateProduct(Products product)
        {
            using (var productDbContext = new ProductDbContext())
            {
                productDbContext.Products.Update(product);
                productDbContext.SaveChanges();
                return product;
            }
        }
    }
}
