using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Utility;

using HandIn4.Models;

namespace HandIn4.CRUD
{
   public class CrudSensorData
    {

        public void Create(SensorData data)
        {
            var db = new Context();
            //foreach (var reading in data.reading)
            //{
            //    db.Readings.Add(reading);
            //}

            db.SensorDatas.Add(data);
            db.SaveChanges();

            
        }

        public SensorData Read(int id)
        {
            var db = new Context();
            var dataToRead = db.SensorDatas.Find(id);
            
                return dataToRead;
            
            
        }

        public void Update(int id)
        {
            var db = new Context();
            var dataToUpdate = db.SensorDatas.Find(id);
            
     
            

        }

        public void Delete(int id)
        {
            var db = new Context();
            var dataToDelete = db.SensorDatas.Find(id);
            if (dataToDelete != null)
            {
                db.SensorDatas.Remove(dataToDelete);
                db.SaveChanges();
            }
        }

    }

    
}
