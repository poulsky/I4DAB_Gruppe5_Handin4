using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandIn4.Model;

namespace HandIn4.Models
{
    public class Context : DbContext
    {
        public Context() : base("name=Model1")
        {
            
        }
        public DbSet<Appartmentcharacteristic> Appartmentcharacteristics { get; set; }
        public DbSet<SensorData> SensorDatas { get; set; }
        public DbSet<Sensorcharacteristic> Sensorcharacteristics { get; set; }
        public DbSet<SystemData> SystemDatas { get; set; }
        public DbSet<Reading> Readings { get; set; }
        public DbSet<LogReadings> LogReadingses { get; set; }

    }
}
