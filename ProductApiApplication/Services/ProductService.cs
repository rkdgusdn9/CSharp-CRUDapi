using ProductApiApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductApiApplication.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetById(int id)
        {
            return _productRepository.GetAll().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> SearchByName(string searchTerm)
        {
            return _productRepository.GetAll().Where(x => x.Name.Contains(searchTerm));
        }

        public Product Add(string name)
        {
            var newProduct = new Product()
            {
                Id = _productRepository.GetAll().Max(x => x.Id) + 1,
                Name = name
            };

            return _productRepository.Add(newProduct);
        }

        public Product Update(int id, string newName)
        {
            var updateProduct = new Product()
            {
                Id = id,
                Name = newName
            };
            return _productRepository.Update(updateProduct);
        }

        public void Delete(int id)
        {
               var removeProduct = _productRepository.GetAll().SingleOrDefault(x => x.Id == id);

                _productRepository.Delete(removeProduct);
        }
        
    }
}
