using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Utility;

namespace HandIn4
{
    class ApartmentcharacteristicJSONutil
    {
        private string portnumber, hostname, servicepath;
        private string fullservicepath;

        public ApartmentcharacteristicJSONutil(string hname, string portno, string serpath)
        {
            portnumber = portno;
            hostname = "http://" + hname + ":" + portno + "/";
            servicepath = serpath + "/";
            fullservicepath = "http://" + hname + ":" + portno + "/" + servicepath;
        }

        Appartmentcharacteristic GetAppartment(Appartmentcharacteristic app)
        {
            APIGetJSON<Appartmentcharacteristic> appGet = new APIGetJSON<Appartmentcharacteristic>(fullservicepath + "Appartmentcharacteristic" + app.No);
            return appGet.data;
        }
    }
}
