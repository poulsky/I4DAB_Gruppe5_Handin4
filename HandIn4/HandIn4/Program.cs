using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Utility;
using System.Data.Entity;
using HandIn4.CRUD;
using HandIn4.Models;

namespace HandIn4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                SensorData mySensorData = new SensorData();
                SystemData mySystemData = new SystemData();
                Reading myReading = new Reading();
                SensorDataJSON sensorDataJson = new SensorDataJSON();
                mySensorData = sensorDataJson.GetAppartment();

                SystemDataJSON sensorCharacteristicJson = new SystemDataJSON();
                mySystemData = sensorCharacteristicJson.GetAppartment();

                CrudSensorData myCrudSensorData = new CrudSensorData();
               // myCrudSensorData.Create(mySensorData);
                 
                Console.WriteLine(myCrudSensorData.Read(3).timestamp);
                myCrudSensorData.Delete(3);
                Console.WriteLine(myCrudSensorData.Read(3).timestamp);
                //foreach (var reading in mySensorData.reading)
                //{
                //    db.Readings.Add(reading);
                //}
                //db.SaveChanges();

                //foreach (var sensorChar in mySystemData.sensorCharacteristic)
                //{
                //    db.Sensorcharacteristics.Add(sensorChar);

                //}
                //db.SaveChanges();

                //foreach (var appChar in mySystemData.appartmentCharacteristic)
                //{
                //    db.Appartmentcharacteristics.Add(appChar);
                //}
                //db.SaveChanges();

            }
                
           

        }
    }
}
