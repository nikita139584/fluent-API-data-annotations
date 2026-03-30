using System.ComponentModel.DataAnnotations;
namespace ConsoleApp74.Models;

public class Review
{
    public int Id { get; set; }

    [Range(1, 5)]
    public int Rating { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }
}