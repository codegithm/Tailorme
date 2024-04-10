using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.DTOs.Common;

namespace TailorMe.Application.DTOs.TopMeasurement
{
    public class TopMeasurementDto : BaseDto
    {
        public int ChestCircumference { get; set; }
        public int NeckCircumference { get; set; }
        public int ShoulderWidth { get; set; }
        public int ArmLength { get; set; }
        public int ArmCircumference { get; set; }
    }
}
