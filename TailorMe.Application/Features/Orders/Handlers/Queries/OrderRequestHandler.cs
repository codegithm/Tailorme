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
    public class OrderRequestHandler : IRequestHandler<OrderRequest, OrderDto>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderRequestHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<OrderDto> Handle(OrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.Get(request.PersonId);
            if (order == null)
                throw new Exception();

            return _mapper.Map<OrderDto>(order);
        }
    }
}
