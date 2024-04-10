using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Domain.Common;

namespace TailorMe.Domain.Entites
{
    public class TopMeasurement : Base
    {
        public int ChestCircumference { get; set; }
        public int NeckCircumference { get; set; }
        public int ShoulderWidth { get; set; }
        public int ArmLength { get; set; }
        public int ArmCircumference { get; set; }
    }
}
