using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data
{
    public class OrderItemRepository
    {
        private readonly AppDbContext _context;

        public OrderItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<OrderItem>> GetItemsByOrderIdAsync(int orderId)
        {
            return await _context.OrderItems
                .Where(i => i.OrderId == orderId)
                .ToListAsync();
        }

        public async Task AddOrderItemAsync(OrderItem item)
        {
            await _context.OrderItems.AddAsync(item);
        }

        public async Task UpdateOrderItemAsync(OrderItem item)
        {
            _context.OrderItems.Update(item);
            await Task.CompletedTask;
        }

        public async Task DeleteOrderItemAsync(OrderItem item)
        {
            _context.OrderItems.Remove(item);
            await Task.CompletedTask;
        }
    }
}