using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.BottomMeasurement;
using TailorMe.Application.Features.BottomMeasurements.Requests.Queries;
using TailorMe.Application.Persistence.Contrants;

namespace TailorMe.Application.Features.BottomMeasurements.Handlers.Queries
{
    public class BottomMeasurementsRequestHandler : IRequestHandler<BottomMeasurementsRequest, BottomMeasurementDto>
    {
        private readonly IBottomMeasurementRepository _bottomMeasurementRepository;
        private readonly IMapper _mapper;

        public BottomMeasurementsRequestHandler(IBottomMeasurementRepository bottomMeasurementRepository, IMapper mapper)
        {
            _bottomMeasurementRepository = bottomMeasurementRepository;
            _mapper = mapper;
        }
        public async Task<BottomMeasurementDto> Handle(BottomMeasurementsRequest request, CancellationToken cancellationToken)
        {
            var measurement = await _bottomMeasurementRepository.Get(request.PersonId);
            if (measurement == null)
                throw new Exception();

            return _mapper.Map<BottomMeasurementDto>(measurement);  
        }
    }
}
