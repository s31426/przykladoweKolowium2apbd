namespace przykladoweKolowium2apbd.DTOs;

public class OrderDto
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime FulfilledAt { get; set; }
    public string Status { get; set; }
    public ClientInfoDto ClientInfo { get; set; }
    public List<ProductInfoDto> Products { get; set; }
}

public class ClientInfoDto
{
    public string firstName { get; set; }
    public string lastName { get; set; }
}

public class ProductInfoDto
{
    public string Name { get; set; }
    public float Price { get; set; }
    public int Amount { get; set; }
}