﻿using ProductApiApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiApplication.Services
{
    public interface IProductRepository
    {
        IList<Product> GetAll();

        void Add(Product newproduct);
    }
}
