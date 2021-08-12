using ProductApiApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiApplication.Services
{
    public class ProductRepository : IProductRepository
    {
        private static readonly IList<Product> _products = new List<Product>
        {
            new Product(){ Id = 1, Name = "Apple"},
            new Product(){ Id = 2, Name = "Banana"},
            new Product(){ Id = 3, Name = "Cherry"},
            new Product(){ Id = 4, Name = "Durian"},
            new Product(){ Id = 5, Name = "Eggplant"},
            new Product(){ Id = 6, Name = "Feijoa"},
            new Product(){ Id = 7, Name = "Grape"},
            new Product(){ Id = 8, Name = "Honeydew"},
        };

        public IList<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product newproduct)
        {
            _products.Add(newproduct);
        }

        public Product Update(Product updateProduct)
        {
            var existProduct = _products.SingleOrDefault(x => x.Id == updateProduct.Id);
            if (existProduct != null)
            {
                existProduct.Name = updateProduct.Name;
            }

            return existProduct;
        }

        public void Delete(Product removeProduct)
        {
            _products.Remove(removeProduct);
        }
    }
}
