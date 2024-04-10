using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Order;
using TailorMe.Application.Features.Orders.Requests.Queries;
using TailorMe.Application.Persistence.Contrants;

namespace TailorMe.Application.Features.Orders.Handlers.Queries
{
    public class OrdersRequestHandler : IRequestHandler<OrdersRequest, List<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrdersRequestHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<List<OrderDto>> Handle(OrdersRequest request, CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetAll();
            if (!orders.Any())
                throw new Exception();

            return _mapper.Map<List<OrderDto>>(orders);
        }
    }
}
