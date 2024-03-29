﻿using SupermarketMgmt.CoreBusiness;
using SupermarketMgmt.UseCases.DataStorePluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product() {ProductId = 1, CategoryId = 1, Name = "Ice Tea", Quantity = 99, Price = 1.98},
                new Product() {ProductId = 2, CategoryId = 1, Name = "Canada Dry", Quantity = 100, Price = 1.99},
                new Product() {ProductId = 3, CategoryId = 2, Name = "Whole Wheat Bread", Quantity = 299, Price = 1.40},
                new Product() {ProductId = 4, CategoryId = 2, Name = "White Bread", Quantity = 300, Price = 1.50}
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }
        public Product GetProductById(int productId)
        {
            var product = products.FirstOrDefault(x => x.ProductId == productId);
            return product ?? new Product();
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);

            if (productToDelete != null) products.Remove(productToDelete);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }
    }
}
