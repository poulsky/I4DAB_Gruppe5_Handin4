using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Model
{
    public class SensorData
    {
        public int SensorDataId { get; set; }
        public int version { get; set; }
        public DateTime timestamp { get; set; }
        public virtual Reading[] reading { get; set; }
    }
}
