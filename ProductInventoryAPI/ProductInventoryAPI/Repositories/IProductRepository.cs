﻿using ProductInventoryAPI.Entities;

namespace ProductInventoryAPI.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);
    }
}