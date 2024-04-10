using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Domain.Common;
using TailorMe.Domain.Enums;

namespace TailorMe.Domain.Entites
{
    public class Order : Base
    {
        public DateTime DateCreated { get; set; }
        public int ItemId { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public string DriverInstructions { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
