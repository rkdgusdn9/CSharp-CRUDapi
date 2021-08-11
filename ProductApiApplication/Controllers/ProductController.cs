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

        [HttpGet("{getbyid}/{id:int}")]
        public IActionResult GetbyId(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound("product with id not found");
            }
            return Ok(product);
        }

       [HttpGet("{name}")]
        public IActionResult Search(string searchTerm)
        {
            return Ok();
        }

        [HttpPost("{create}")]
        public IActionResult Create(CreateProductViewModel requestModel)
        {
            return Ok();
        }

        [HttpPost("{update}")]
        public IActionResult Update(UpdateProductViewModel model)
        {
            return Ok();
        }

        [HttpPost("{delete}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
