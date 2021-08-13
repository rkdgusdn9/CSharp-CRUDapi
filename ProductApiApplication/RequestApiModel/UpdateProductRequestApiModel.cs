using System.ComponentModel.DataAnnotations;

namespace ProductApiApplication.ViewModel
{
    public class UpdateProductRequestApiModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
