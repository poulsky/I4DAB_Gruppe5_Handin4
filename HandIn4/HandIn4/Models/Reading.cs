﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4.Model
{
    public class Reading
    {

        public long ReadingId { get; set; } //Eget felt
        public int sensorId { get; set; }
        public int appartmentId { get; set; }
        public float value { get; set; }
        public DateTime timestamp { get; set; }
    }
}
