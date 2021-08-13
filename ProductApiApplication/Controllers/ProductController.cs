using Microsoft.AspNetCore.Mvc;
using ProductApiApplication.Services;
using ProductApiApplication.ViewModel;

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
                return NotFound("Product with id not found");
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
        public IActionResult Create(CreateProductRequestApiModel requestModel)
        {
            var created = _productService.Add(requestModel.Name);
            if (created == null)
            {
                return NotFound("Name cannot be null");
            }           
            
            return Ok(created);
        }

        [HttpPost("update")]
        public IActionResult Update(UpdateProductRequestApiModel model)
        {
            var updated = _productService.Update(model.Id, model.Name);
            if (updated == null)
            {
                return NotFound("Id and new name cannot be null");
            }
            return Ok(updated);
        }

        [HttpPost("delete")]
        public IActionResult Delete(DeleteProductRequestApiModel delModel)
        {
            var product = _productService.GetById(delModel.Id);
            if (product == null)
            {
                return NotFound("Product with id not found");
            }
            _productService.Delete(delModel.Id);
            return Ok();
        }
    }
}
