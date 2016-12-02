using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Utility;

namespace HandIn4
{
    class Program
    {
        static void Main(string[] args)
        {
            SensorData mySensorData = new SensorData();
            SystemData mySystemData = new SystemData();
            SensorDataJSON sensorDataJson = new SensorDataJSON();
            mySensorData = sensorDataJson.GetAppartment();

            SystemDataJSON sensorCharacteristicJson = new SystemDataJSON();
            mySystemData = sensorCharacteristicJson.GetAppartment();

            

            foreach (var sensor in mySystemData.sensorCharacteristic)
            {
                System.Console.WriteLine(sensor.description);
            }

        }
    }
}
