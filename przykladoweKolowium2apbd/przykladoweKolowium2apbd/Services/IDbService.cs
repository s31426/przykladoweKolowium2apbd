using przykladoweKolowium2apbd.DTOs;

namespace przykladoweKolowium2apbd.Services;

public interface IDbService
{
    Task<OrderDto> GetOrderById(int orderId);
}