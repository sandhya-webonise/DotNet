using System.ComponentModel.DataAnnotations;
namespace ContosoPizza.Models;

public class Pizza
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
}