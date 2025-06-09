using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace przykladoweKolowium2apbd.Models;

[Table("Client")]
public class Client
{
    [Key]
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    
    public ICollection<Order> Orders { get; set; } = null!;
}