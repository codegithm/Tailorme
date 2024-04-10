using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.TopMeasurement;
using TailorMe.Application.Features.TopMeasurements.Requests.Queries;
using TailorMe.Application.Persistence.Contrants;

namespace TailorMe.Application.Features.TopMeasurements.Handlers.Queries
{
    public class TopMeasurementsRequestHandler : IRequestHandler<TopMeasurementsRequest, TopMeasurementDto>
    {
        private readonly ITopMeasurementRepository _topMeasurementRepository;
        private readonly IMapper _mapper;

        public TopMeasurementsRequestHandler(ITopMeasurementRepository bottomMeasurementRepository, IMapper mapper)
        {
            _topMeasurementRepository = bottomMeasurementRepository;
            _mapper = mapper;
        }
        public async Task<TopMeasurementDto> Handle(TopMeasurementsRequest request, CancellationToken cancellationToken)
        {
            var measurement = await _topMeasurementRepository.Get(request.PersonId);
            if (measurement == null)
                throw new Exception();

            return _mapper.Map<TopMeasurementDto>(measurement);
        }
    }
}
