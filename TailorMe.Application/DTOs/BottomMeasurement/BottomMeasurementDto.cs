using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Common;

namespace TailorMe.Application.DTOs.BottomMeasurement
{
    public class BottomMeasurementDto : BaseDto
    {
        public int WaistCircumference { get; set; }
        public int HipCircumference { get; set; }
        public int ThighCircumference { get; set; }
        public int KneeCircumference { get; set; }
        public int CuffCircumference { get; set; }
        public int InseamLength { get; set; }
        public int OutseamLength { get; set; }
        public int FrontRise { get; set; }
        public int BackRise { get; set; }
    }
}
