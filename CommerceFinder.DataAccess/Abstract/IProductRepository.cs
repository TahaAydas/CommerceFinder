using System;
using System.Collections.Generic;
using System.Text;
using CommerceFinder.Entities;

namespace CommerceFinder.DataAccess.Abstract
{
    public interface IProductRepository
    {
        List<Products>GetAllProducts();

        Products GetProductById(int id);

        Products CreateProduct(Products product);

        Products UpdateProduct(Products product);

        void DeleteProduct(int id);
    }
}
