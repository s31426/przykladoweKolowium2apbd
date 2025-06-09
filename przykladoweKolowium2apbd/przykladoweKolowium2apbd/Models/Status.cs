using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace przykladoweKolowium2apbd.Models;

[Table("Status")]
public class Status
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<Order> Orders { get; set; } = null!;
}