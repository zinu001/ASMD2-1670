using Asm2.Models;
using System.ComponentModel.DataAnnotations;

namespace Asm2.ViewModel
{
    public class BookViewModel
    {
        [Required(ErrorMessage = "Please enter title")]
        [Display(Name = "Title")]
        [StringLength(50)]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        [Display(Name = "Description")]
        [StringLength(100)]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Please enter quantity")]
        [Display(Name = "Quantity")]
        public int? Quantity { get; set; }
        [Required(ErrorMessage = "Please enter year")]
        [Display(Name = "Year")]
        public DateTime Year { get; set; }
        [Required(ErrorMessage = "Please enter price")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Please enter Image")]
        [Display(Name = "Picture")]
        public IFormFile? BookPicture { get; set; }

        /*One to Many*/

        /*one book have many order*/
        public ICollection<Order>? Orders { get; set; } /*Relationship*/

        /*One to Many*/

        /*one book have many cate*/
        public ICollection<Category>? Categorys { get; set; } /*Relationship*/
    }
}
