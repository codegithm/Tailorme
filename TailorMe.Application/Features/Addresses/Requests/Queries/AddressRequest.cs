using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Address;

namespace TailorMe.Application.Features.Addresses.Requests.Queries
{
    public class AddressRequest : IRequest<AddressDto>
    {
        public int PersonId { get; set; }
    }
}
