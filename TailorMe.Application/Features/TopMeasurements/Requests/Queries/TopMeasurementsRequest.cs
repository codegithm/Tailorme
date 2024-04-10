using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.TopMeasurement;

namespace TailorMe.Application.Features.TopMeasurements.Requests.Queries
{
    public class TopMeasurementsRequest : IRequest<TopMeasurementDto>
    {
        public int PersonId { get; set; }
    }
}
