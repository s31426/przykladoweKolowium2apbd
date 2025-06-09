using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace przykladoweKolowium2apbd.Models;
[Table("Product")]
public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    
    public ICollection<ProductOrder> PrductOrders { get; set; } = null!;
}