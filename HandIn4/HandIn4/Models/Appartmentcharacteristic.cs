using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Model
{
    public class Appartmentcharacteristic
    {
        public int No { get; set; }
        public float Size { get; set; }
        public int Floor { get; set; }
        [Key]
        public int appartmentId { get; set; }
    }

    class AppartmentcharacteristicList
    {
        private List<Appartmentcharacteristic> Appartmentcharacteristics { get; set; }
    }
}
