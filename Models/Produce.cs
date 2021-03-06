namespace LocalProduce.Models;
using System.ComponentModel.DataAnnotations;

public class Produce
{

    public int? ProduceId { get; set; }

    [Required]
    public string? Producer { get; set; }
    [Required]
    public int? Price { get; set; }
    [Required]
    public string? PickupPlace { get; set; }
    [Required]
    public string? Area { get; set; }
    [Required]
    public string? Theme { get; set; }
    [Required]
    public string? Description { get; set; }

    public List<Customer>? Customer { get; set; }

}
