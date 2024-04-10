using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.BottomMeasurement;

namespace TailorMe.Application.Features.BottomMeasurements.Requests.Queries
{
    public class BottomMeasurementsRequest : IRequest<BottomMeasurementDto>
    {
        public int PersonId { get; set; }
    }
}
