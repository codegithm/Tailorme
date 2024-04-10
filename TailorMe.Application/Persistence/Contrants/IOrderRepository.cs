using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Domain.Entites;

namespace TailorMe.Application.Persistence.Contrants
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<List<Order>> GetPersonOrdersById(int personId);
        Task<List<Order>> GetAllDeliveredOrders();
        Task<List<Order>> GetAllCancelledOrders();
        Task<List<Order>> GetAllRefundedOrders();
        Task<List<Order>> GetPersonOrdersbyDate(int personId, DateTime dateCreated);
    }
}
