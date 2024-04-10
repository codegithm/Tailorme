using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Common;
using TailorMe.Domain.Enums;

namespace TailorMe.Application.DTOs.Order
{
    public class OrderDto : BaseDto
    {
        public DateTime DateCreated { get; set; }
        public int ItemId { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public string DriverInstructions { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
