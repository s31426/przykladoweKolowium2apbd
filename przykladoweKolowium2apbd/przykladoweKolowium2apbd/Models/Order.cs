using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace przykladoweKolowium2apbd.Models;

[Table("Order")]
public class Order
{
    [Key]
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime FulfilledAt { get; set; }
    
    public Client Client { get; set; }
    [ForeignKey(nameof(Client))]
    public int ClientId { get; set; }
    
    public Status Status { get; set; }
    [ForeignKey(nameof(Status))]
    public int StatusId { get; set; }
    
    public ICollection<ProductOrder> ProductOrders { get; set; } = null!;
    
    
}