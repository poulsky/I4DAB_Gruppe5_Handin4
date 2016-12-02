using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Model
{
    public class SystemData
    {
        public int SystemDataId { get; set; } //eget felt
        public Appartmentcharacteristic[] appartmentCharacteristic { get; set; }
        public DateTime timestamp { get; set; }
        public int version { get; set; }
        public Sensorcharacteristic[] sensorCharacteristic { get; set; }
    }
}
