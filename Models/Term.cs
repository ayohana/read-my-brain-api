using System.ComponentModel.DataAnnotations;

namespace ReadMyBrainAPI.Models
{
  public class Term
  {
    [Key]
    public int TermID { get; set; }
    [Required]
    [StringLength(10, ErrorMessage="A term name cannot exceed 10 characters.")]
    public string Name { get; set; }
    [Required]
    [StringLength(50, ErrorMessage="Definition of a term cannot exceed 50 characters.")]
    public string Definition { get; set; }
  }
}