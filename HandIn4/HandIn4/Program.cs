using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Utility;
using System.Data.Entity;
using System.Data.SqlClient;
using HandIn4.Models;

namespace HandIn4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                //SensorData mySensorData = new SensorData();
                //SystemData mySystemData = new SystemData();
                //Reading myReading = new Reading();
                
                //SensorDataJSON sensorDataJson = new SensorDataJSON();
                //mySensorData = sensorDataJson.GetAppartment();

                //SystemDataJSON sensorCharacteristicJson = new SystemDataJSON();
                //mySystemData = sensorCharacteristicJson.GetAppartment();
                
           
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
                DateTime myTime = DateTime.MaxValue;
                
                ReadingItem puha = new ReadingItem() {appartmentId = 69, sensorId = 69, timestamp = DateTime.Parse("08-10-2014 07:57:13") ,  value = 69};
                ReadingItems puhalist = new ReadingItems();
                puhalist.Add(puha);

                AddDataToApartment(puhalist);
                
            }
                
           

        }


        static void AddDataToApartment(ReadingItems items)
        {
            using (
                SqlConnection sqlcon =
                    new SqlConnection(
                        @"Data Source=(localdb)\ProjectsV13;Initial Catalog=HandIn4.Model1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            )
            {
                using (SqlCommand cmd = new SqlCommand("InsertProcedure", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Items", SqlDbType.Structured).Value = items.GetItemsAsDataTable();
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

   
}
