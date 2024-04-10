using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorMe.Domain.Enums
{
    public enum OrderStatus
    {
        Tailoring,
        AwaitingPickup,
        InTransit,
        Delivered,
        Cancelled,
        Refunded
    }
}
