using System.ComponentModel.DataAnnotations;

namespace Asm2.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Please enter quantity")]
        [Display(Name = "Quantity")]
        public int? Qty { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [Display(Name = "Email")]
        [StringLength(30)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter price")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Please enter time to order")]
        [Display(Name = "OrderTime")]
        public DateTime OrderTime { get; set; }

        public int BookId { get; set; }

        public int CustomerId { get; set; }
    }
}
