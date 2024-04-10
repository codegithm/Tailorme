using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.Features.TopMeasurements.Requests.Commands;
using TailorMe.Application.Persistence.Contrants;
using TailorMe.Domain.Entites;

namespace TailorMe.Application.Features.TopMeasurements.Handlers.Commands
{
    public class CreateTopMeasurementCommandHandler : IRequestHandler<CreateTopMeasurementCommand, int>
    {
        private readonly ITopMeasurementRepository _topMeasurementRepository;
        private readonly IMapper _mapper;

        public CreateTopMeasurementCommandHandler(ITopMeasurementRepository topMeasurementRepository, IMapper mapper)
        {
            _topMeasurementRepository = topMeasurementRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateTopMeasurementCommand request, CancellationToken cancellationToken)
        {
            var topMeasurement = _mapper.Map<TopMeasurement>(request.CreateTopMeasurementDto);
            var createMeasurement = await _topMeasurementRepository.Add(topMeasurement);

            return createMeasurement.Id;
        }
    }
}
