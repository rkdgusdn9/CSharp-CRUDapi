using System.ComponentModel.DataAnnotations;

namespace ProductApiApplication.ViewModel
{
    public class DeleteProductRequestApiModel
    {
        [Required]
        public int Id { get; set; }
    }
}
