using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Model
{
    public class Sensorcharacteristic
    {
        public int SensorcharacteristicId { get; set; } //eget felt
        public string calibrationCoeff { get; set; }
        public string description { get; set; }
        public DateTime calibrationDate { get; set; }
        public string externalRef { get; set; }
        
        public int sensorId { get; set; }
        public string unit { get; set; }
        public string calibrationEquation { get; set; }
    }
}
