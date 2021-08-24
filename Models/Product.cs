using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meus_Produtos.Models
{   
    [Table("Products")] 
    public class Product
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(80),MinLength(3)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Please enter a valid price")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Please enter a valid price")]
        public decimal Price { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
