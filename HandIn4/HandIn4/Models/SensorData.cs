using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Model
{
    class SensorData
    {
        public int version { get; set; }
        public DateTime timestamp { get; set; }
        public Reading[] reading { get; set; }
    }
}
