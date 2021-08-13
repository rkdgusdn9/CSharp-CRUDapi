using ProductApiApplication.Models;
using System.Collections.Generic;

namespace ProductApiApplication.Services
{
    public interface IProductService
    {
        Product GetById(int id);

        IEnumerable<Product> SearchByName(string searchTerm);

        Product Add(string name);

        Product Update(int id, string name);

        void Delete(int id);
    }
}
