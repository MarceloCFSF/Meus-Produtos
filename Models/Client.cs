using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meus_Produtos.Models
{ 
  [Microsoft.EntityFrameworkCore.Index(nameof(Email), IsUnique = true)]
  [Table("Clients")]
  public class Client
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        [MaxLength(20),MinLength(3)]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(20),MinLength(8)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
