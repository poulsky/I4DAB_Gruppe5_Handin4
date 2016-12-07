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
    class SystemDataJSON
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

        public SystemData GetAppartment(string data)
        {
            //APIGetJSON<SystemData> appGet = new APIGetJSON<SystemData>("http://userportal.iha.dk/~jrt/i4dab/E14/HandIn4/GFKSC002_original.txt");
            // Sensorcharacteristic mySensorData = JsonConvert.DeserializeObject<Sensorcharacteristic>(appGet.data);
            APIGetJSON<SystemData> appGet = new APIGetJSON<SystemData>(data);
            return appGet.data;

        }


    }
}
