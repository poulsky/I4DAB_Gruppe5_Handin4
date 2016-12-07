using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Models;

namespace HandIn4.Utility
{
    public class UserStories
    {
        public float AccumulatedHeatEnergy(int id)
        {
            using (var context = new Context())
            {
                var ap = context.Readings.Where(t => t.appartmentId == id);
                List<int> Id = new List<int>();
                foreach (var reading in ap)
                {
                    Id.Add(reading.sensorId);
                }

                int sensorId = 0;
                foreach (var item in Id)
                {
                    var sensor =
                        context.Sensorcharacteristics.SingleOrDefault(
                            t => t.sensorId == item && t.description == "(*Accumulated Energy consumption kWh*)");
                    if (sensor != null)
                    {
                        sensorId = sensor.sensorId;
                        break;
                    }
                }
                var re = context.Readings.Where(t => t.sensorId == sensorId);
                DateTime time = DateTime.MinValue;
                float sensorValue = 0;
                foreach (var reading in re)
                {
                    if (time < reading.timestamp)
                    {
                        sensorValue = reading.value;
                        time = reading.timestamp;
                    }     
                }

                return sensorValue;
            }
        }

        public Appartmentcharacteristic GetApartmentData(int apartmentId)
        {
            var db = new Context();
            
            return db.Appartmentcharacteristics.Find(apartmentId);
        }

        public int GetNumberOfApartmentsInSystem()
        {
            var db = new Context();
            
            return db.Appartmentcharacteristics.Count();

        }

        public float GetCurrentHeatEnergyConsumption(int apartmentId)
        {
            var db = new Context();

            var ap = db.Readings.Where(t => t.appartmentId == apartmentId);
            List<int> Id = new List<int>();
            foreach (var reading in ap)
            {
                Id.Add(reading.sensorId);
            }

            int sensorId = 0;
            foreach (var item in Id)
            {
                var sensor =
                    db.Sensorcharacteristics.SingleOrDefault(
                        t => t.sensorId == item && t.description == "(*Instant  Heat Energy consumption W*)");
                if (sensor != null)
                {
                    sensorId = sensor.sensorId;
                    break;
                }
            }

            var re = db.Readings.Where(t => t.sensorId == sensorId);
            DateTime time = DateTime.MinValue;
            float sensorValue = -1;
            foreach (var reading in re)
            {
                if (time < reading.timestamp)
                {
                    sensorValue = reading.value;
                    time = reading.timestamp;
                }
            }
            
            return sensorValue;
        }
    }
}
