using System.ComponentModel.DataAnnotations;

namespace ProductApiApplication.ViewModel
{
    public class CreateProductRequestApiModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
