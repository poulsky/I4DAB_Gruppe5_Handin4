using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Models;
using System.Threading;

namespace HandIn4.Utility
{
    public class UserInterface
    {
        int _addrID = 0;
        UserStories _us = new UserStories();
        public UserInterface()
        {
            Console.WriteLine("Type your AddrID");
            var addr=Console.ReadLine();
            _addrID = Int32.Parse(addr);
            DisplayFrontPage();
        }

        public void ExtractJsonFiles(int from, int to)
        {
            if(from >= 1 && from <=to && to < 11000)
            using (var db = new Context())
            {
                SensorData mySensorData = new SensorData();
                
                Reading myReading = new Reading();
                SensorDataJSON sensorDataJson = new SensorDataJSON();

                for (int i = from; i < to; i++)
                {
                    string data = "http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/dataGDL/data/" + i + ".json";
                    mySensorData = sensorDataJson.GetAppartment(data);
                    foreach (var reading in mySensorData.reading)
                    {
                        db.Readings.Add(reading);
                    }
                    db.SaveChanges();
                    Thread.Sleep(5000);
                }
            }
        }

        public void DisplayFrontPage()
        {
            Console.Clear();
            Console.WriteLine("Press H to see AccumulatedHeatEnergyPress D to see GetApartmentData");
            Console.WriteLine("Press D to see GetApartmentData");
            Console.WriteLine("Press S to see  GetNumberOfApartmentsInSystem");
            Console.WriteLine("Press C to see  GetCurrentHeatEnergyConsumption");
            Console.WriteLine("Press A to to change address id");
            Console.WriteLine("Press E to extract Json files");

            var key=Console.ReadKey().KeyChar;
            key=Char.ToUpper(key);
            DisplayData(key);

        }

        public void DisplayData(char key)
        {
            
            Console.Clear();
            switch (key)
            {
                case 'H':
                    {
                        var sensorValue = _us.AccumulatedHeatEnergy(_addrID);
                        Console.WriteLine(sensorValue);
                    }
                    break;
                case 'D':
                    {
                        var apData = _us.GetApartmentData(_addrID);
                        Console.WriteLine(apData.appartmentId + " " + apData.Floor + " " + apData.No + " " + apData.Size);
                    }

                    break;
                case 'S':
                    Console.WriteLine(_us.GetNumberOfApartmentsInSystem());
                    break;
                case 'C':
                    Console.WriteLine(_us.GetCurrentHeatEnergyConsumption(_addrID));
                    break;

                case 'E':
                    {
                        Console.WriteLine("Enter desired Json files(From and to)");
                        Console.WriteLine("From: ");
                        int from = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("To: ");
                        int to = Int32.Parse(Console.ReadLine());

                        ExtractJsonFiles(from, to);
                    }
                    break;

                case 'A':
                    {
                        Console.WriteLine("Type your AddrID");
                        var addr = Console.ReadLine();
                        _addrID = Int32.Parse(addr);

                    }
                    break;

                default:
                    Console.WriteLine("This is not and options");
                    break; 

            }
            Console.WriteLine("Press key to continue to main menu");
            Console.ReadKey();
            DisplayFrontPage();

        }

       



    }
}
