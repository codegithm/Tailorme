using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Address;
using TailorMe.Application.Features.Addresses.Requests.Queries;
using TailorMe.Application.Persistence.Contrants;

namespace TailorMe.Application.Features.Address.Handlers.Queries
{
    public class AddressRequestHandler : IRequestHandler<AddressRequest, AddressDto>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public AddressRequestHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<AddressDto> Handle(AddressRequest request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.Get(request.PersonId);
            if (address == null)
                throw new Exception();

            return _mapper.Map<AddressDto>(address);
        }
    }
}
