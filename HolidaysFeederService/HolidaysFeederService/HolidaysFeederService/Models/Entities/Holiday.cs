using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidaysFeederService.Models.Entities
{
    public class Holiday
    {
        public int HolidayId { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public Holiday( int day, int month, int year, string description)
        {
            Day = day;
            Month = month;
            Year = year;
            Description = description;
        }
    }
}
