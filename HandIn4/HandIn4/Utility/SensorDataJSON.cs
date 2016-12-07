using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Utility;
using Newtonsoft.Json;

namespace HandIn4.Utility
{
    class SensorDataJSON
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;

        //public SensorCharacterusticJSON(string hname, string portno, string serpath)
        //{
        //    portnumber = portno;
        //    hostname = "http://" + hname + ":" + portno + "/";
        //    servicepath = serpath + "/";
        //    fullservicepath = "http://" + hname + ":" + portno + "/" + servicepath;
        //}

        public SensorData GetAppartment(string data)
        {
            //APIGetJSON<SensorData> appGet = new APIGetJSON<SensorData>("http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/dataGDL/data/2.json");
           // Sensorcharacteristic mySensorData = JsonConvert.DeserializeObject<Sensorcharacteristic>(appGet.data);
            return appGet.data;

        }

      
    }
}
