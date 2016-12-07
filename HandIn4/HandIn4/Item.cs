using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn4
{
    public class ReadingItem
    {
        //public long ReadingId { get; set; } //Eget felt
        public int sensorId { get; set; }
        public float value { get; set; }
        public DateTime timestamp { get; set; }
        public int appartmentId { get; set; }
    }

    public class ReadingItems : List<ReadingItem>
    {
        public DataTable GetItemsAsDataTable()
        {
            DataTable table = new DataTable();
           // table.Columns.Add("ReadingId", typeof(long));
            table.Columns.Add("sensorId", typeof(int));
            table.Columns.Add("value", typeof(float));
            table.Columns.Add("timestamp", typeof(DateTime));
            table.Columns.Add("appartmentId", typeof(int));

            foreach (var item in this)
            {
                table.Rows.Add( item.sensorId, item.value, item.timestamp);
            }
            return table;
        }
    }



}
