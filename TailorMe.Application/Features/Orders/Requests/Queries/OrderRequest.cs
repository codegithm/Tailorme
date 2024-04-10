using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Order;

namespace TailorMe.Application.Features.Orders.Requests.Queries
{
    public class OrderRequest : IRequest<OrderDto>
    {
        public int PersonId { get; set; }
    }
}
