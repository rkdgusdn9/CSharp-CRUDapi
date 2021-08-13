using ProductApiApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiApplication.Services
{
    public interface IProductRepository
    {
        IList<Product> GetAll();

        Product Add(Product newProduct);
        Product Update(Product updateProduct);

        Product Delete(Product removeProduct);
    }
}
