using System.ComponentModel.DataAnnotations;
namespace ConsoleApp74.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
}