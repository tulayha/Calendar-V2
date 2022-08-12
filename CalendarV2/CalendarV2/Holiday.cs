using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarV2
{
    public class Holiday
    {
        public string title { get; set; }
        public string details { get; set; }
        public Holiday(string _title, string _details = "")
        {
            title = _title;
            details = _details;
        }
        public bool isEmpty
        {
            get
            {
                return (title == "");
            }
        }
        public bool isEqual(Holiday holiday)
        {
            return (holiday.title == title && holiday.details == details);
        }
    }
}
