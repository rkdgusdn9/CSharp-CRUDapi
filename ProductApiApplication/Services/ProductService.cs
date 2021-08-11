using ProductApiApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
