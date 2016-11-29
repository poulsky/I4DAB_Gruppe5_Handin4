using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Model
{
    class SystemData
    {
        public Appartmentcharacteristic[] appartmentCharacteristic { get; set; }
        public DateTime timestamp { get; set; }
        public int version { get; set; }
        public Sensorcharacteristic[] sensorCharacteristic { get; set; }
    }
}
