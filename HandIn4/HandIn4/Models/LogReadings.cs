using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Models
{
    public class LogReadings
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Operations { get; set; }
        public int apartmentId { get; set; }
        public int ReadingId { get; set; }
    }
}
