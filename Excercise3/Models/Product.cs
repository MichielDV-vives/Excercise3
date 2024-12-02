using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Excercise3.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [DisplayName("product Name")]
    [Required(ErrorMessage = "The product name is required.")]
    public required string Name { get; set; }
    
    [DisplayName("Description")]
    [StringLength(500, ErrorMessage = "The description must be less than 500 characters.")]
    public string? Description { get; set; }
    
    [DisplayName("Price (€)")]
    [Required(ErrorMessage = "The price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "The price must be greater than zero.")]
    public decimal Price { get; set; }
    public string? Category { get; set; }
}