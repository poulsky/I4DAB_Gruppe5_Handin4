using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Utility;
using System.Data.Entity;
using System.Threading;
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

                string sample = "http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/GFKSC0021_sample.txt";
                string original = "http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/GFKSC002_original.txt";

                SensorDataJSON sensorDataJson = new SensorDataJSON();


                Reading reading1 = new Reading()
                {
                    appartmentId = 160,
                    sensorId = 6666,
                    timestamp = DateTime.MaxValue,
                    value = 420
                };

                Appartmentcharacteristic app1 = new Appartmentcharacteristic()
                {
                    appartmentId = 666,
                    Floor = 34,
                    No = 90,
                    Size = 1
                };

                Sensorcharacteristic sen1 = new Sensorcharacteristic()
                {
                    description = "Accumulated Energy consumption kWh",
                    calibrationCoeff = "0",
                    calibrationDate = DateTime.Today,
                    calibrationEquation = "420",
                    externalRef = " ",
                    sensorId = 6666,
                    unit = "l/min"
                };

                
                db.Readings.Add(reading1);
                db.Appartmentcharacteristics.Add(app1);
                db.Sensorcharacteristics.Add(sen1);
                db.SaveChanges();



                //SystemDataJSON sensorCharacteristicJson = new SystemDataJSON();
                //mySystemData = sensorCharacteristicJson.GetAppartment(sample);


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



                //for (int i = 11; i < 20; i++)
                //{
                //    string data = "http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/dataGDL/data/" + i + ".json";
                //    mySensorData = sensorDataJson.GetAppartment(data);
                //    foreach (var reading in mySensorData.reading)
                //    {
                //        db.Readings.Add(reading);
                //    }
                //    db.SaveChanges();
                //    Thread.Sleep(5000);
                //}
            }

            //Reading reading = new Reading()
            //{
            //    appartmentId = 666,
            //    sensorId = 6666,
            //    timestamp = DateTime.MaxValue,
            //    value = 420
            //};

            //Appartmentcharacteristic app = new Appartmentcharacteristic()
            //{
            //    appartmentId = 666,
            //    Floor = 34,
            //    No = 90,
            //    Size = 1
            //};

            //Sensorcharacteristic sen = new Sensorcharacteristic()
            //{
            //    description = "Accumulated Energy consumption kWh",
            //    calibrationCoeff = "0",
            //    calibrationDate = DateTime.Today,
            //    calibrationEquation = "420",
            //    externalRef = " ",
            //    sensorId = 6666,
            //    unit = "l/min"
            //};

            //var dbi = new Context();
            //dbi.Readings.Add(reading);
            //dbi.Appartmentcharacteristics.Add(app);
            //dbi.Sensorcharacteristics.Add(sen);
            //dbi.SaveChanges();


            var us = new UserStories();

            int id = 113;

            var sensorValue = us.AccumulatedHeatEnergy(id);
            Console.WriteLine(sensorValue);

            var apData = us.GetApartmentData(id);
            Console.WriteLine(apData.appartmentId + " " + apData.Floor + " " + apData.No + " " + apData.Size);

            Console.WriteLine(us.GetNumberOfApartmentsInSystem());

            Console.WriteLine(us.GetCurrentHeatEnergyConsumption(id));

        }
    }
}
