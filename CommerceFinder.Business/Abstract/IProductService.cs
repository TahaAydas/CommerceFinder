using CommerceFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceFinder.Business.Abstract
{
    public interface IProductService
    {
        List<Products> GetAllProducts();

        Products GetProductById(int id);

        Products CreateProduct(Products product);

        Products UpdateProduct(Products product);

        void DeleteProduct(int id);
    }
}
