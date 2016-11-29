using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Model
{
    class Sensorcharacteristic
    {
        public string calibrationCoeff { get; set; }
        public string description { get; set; }
        public DateTime calibrationDate { get; set; }
        public string externalRef { get; set; }
        public int sensorId { get; set; }
        public string unit { get; set; }
        public string calibrationEquation { get; set; }
    }
}
