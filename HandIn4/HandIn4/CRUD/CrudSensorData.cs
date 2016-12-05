using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Utility;

using HandIn4.Models;

namespace HandIn4.CRUD
{
    class CrudSensorData
    {

        public void Create(SensorData data)
        {
            var db = new Context();
            foreach (var reading in data.reading)
            {
                db.Readings.Add(reading);
            }
            db.SaveChanges();

            db.SensorDatas.Add(data);
        }
    }
}
