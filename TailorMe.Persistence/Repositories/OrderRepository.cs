using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.Persistence.Contrants;
using TailorMe.Domain.Entites;
using TailorMe.Domain.Enums;
using TailorMe.Persistence.Persistence;

namespace TailorMe.Persistence.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext) :
            base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Order>> GetAllCancelledOrders()
        {
            var orders = await _dbContext.Order
                .Where(p => p.OrderStatus == OrderStatus.Cancelled)
                .ToListAsync();
            return orders;
        }

        public async Task<List<Order>> GetAllDeliveredOrders()
        {
            var orders = await _dbContext.Order
                .Where(p => p.OrderStatus == OrderStatus.Delivered)
                .ToListAsync();
            return orders;
        }

        public async Task<List<Order>> GetAllRefundedOrders()
        {
            var orders = await _dbContext.Order
                .Where(p => p.OrderStatus == OrderStatus.Refunded)
                .ToListAsync();
            return orders;
        }

        public async Task<List<Order>> GetPersonOrdersbyDate(int personId, DateTime dateCreated)
        {
            var orders = await _dbContext.Order
                .Where(p => p.PersonId == personId
                && p.DateCreated == dateCreated)
                .ToListAsync();
            return orders;
        }

        public async Task<List<Order>> GetPersonOrdersById(int personId)
        {
            var orders = await _dbContext.Order
                .Where(p => p.PersonId == personId)
                .ToListAsync();
            return orders;
        }
    }
}
