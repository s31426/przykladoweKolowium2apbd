using przykladoweKolowium2apbd.Data;
using przykladoweKolowium2apbd.DTOs;

namespace przykladoweKolowium2apbd.Services;

public class DbService:IDbService
{
    private readonly DataBaseContext _context;

    public DbService(DataBaseContext context)
    {
        _context = context;
    }

    public async Task<OrderDto> GetOrderById(int orderId)
    {
        
    }
}