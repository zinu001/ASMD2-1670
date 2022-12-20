using System.ComponentModel.DataAnnotations;

namespace Asm2.Models
{
    public class Category
    {
        [Key]
        public int  CategoryId { get; set; }
        [Required(ErrorMessage = "Please enter category name")]
        [Display(Name = "Category Name")]
        [StringLength(50)]
        public string? CategoryName { get; set; }
        [Required(ErrorMessage = "Please enter category description")]
        [Display(Name = "Category Description")]
        [StringLength(100)]
        public int CategoryDescription { get; set; }
    }
}
