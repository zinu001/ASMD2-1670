using System.ComponentModel.DataAnnotations;

namespace Asm2.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter Customer Name")]
        [Display(Name = "Customer Name")]
        [StringLength(50)]
        public string? CustomerName { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        [Display(Name = "Email")]
        [StringLength(30)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter gender")]
        [Display(Name = "Gender")]
        [StringLength(10)]
        public string? Gender { get; set; }

        /*One to Many*/

        /*one customer have many order*/
        public ICollection<Order>? Orders { get; set; } /*Relationship*/
    }
}
