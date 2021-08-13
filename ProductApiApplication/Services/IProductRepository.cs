using ProductApiApplication.Models;
using System.Collections.Generic;


namespace ProductApiApplication.Services
{
    public interface IProductRepository
    {
        IList<Product> GetAll();

        Product Add(Product newProduct);

        Product Update(Product updateProduct);

        void Delete(Product removeProduct);
    }
}
