using ProductApiApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiApplication.Services
{
    public interface IProductService
    {
        Product GetById(int id);
        IEnumerable<Product> SearchByName(string searchTerm);
        void Add(string name);
        Product Update(int id, string name);
        void Delete(int id);
    }
}
