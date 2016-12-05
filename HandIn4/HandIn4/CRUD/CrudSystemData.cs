using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;
using HandIn4.Models;

namespace HandIn4.CRUD
{
    class CrudSystemData
    {
        private Context db = new Context();
        public void Create(SystemData data)
        {
            
            
            foreach (var appartmentcharacteristic in data.appartmentCharacteristic)
            {
                db.Appartmentcharacteristics.Add(appartmentcharacteristic);
            }
            foreach (var sensorcharacteristic in data.sensorCharacteristic)
            {
                db.Sensorcharacteristics.Add(sensorcharacteristic);
            }
            db.SystemDatas.Add(data);
            db.SaveChanges();
        }

        public SystemData Read(int id)
        {
            return db.SystemDatas.SingleOrDefault(x => x.SystemDataId == id);
        }

        public void Update(SystemData data)
        {
            var item = this.Read(data.SystemDataId);

            if (item != null)
            {
                item.timestamp = data.timestamp;
                item.version = item.version;

            }
        }

        public void Delete(int id)
        {
            var item = db.SystemDatas.SingleOrDefault(x => x.SystemDataId == id);

            if (item != null)
            {
                db.SystemDatas.Remove(item);
                db.SaveChanges();
            }
        }

        
    }
}
