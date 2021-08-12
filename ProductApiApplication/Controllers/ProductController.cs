using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApiApplication.Models;
using ProductApiApplication.Services;
using ProductApiApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;            
        }


        [HttpGet("getbyid/{id:int}")]
        public IActionResult GetbyId(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound("product with id not found");
            }
            return Ok(product);
        }

       [HttpGet("search")]
        public IActionResult Search(string searchTerm)
        {
            var products = _productService.SearchByName(searchTerm);
            return Ok(products);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateProductViewModel requestModel)
        {
           _productService.Add(requestModel.Name);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(UpdateProductViewModel model)
        {
            var updated = _productService.Update(model.Id, model.Name);
            return Ok(updated);
        }

        [HttpPost("{delete}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
