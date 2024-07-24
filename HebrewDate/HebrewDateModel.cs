using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebrewDate
{
    internal class HebrewDateModel
    {
        public string day { get; set; }
        public string dayMonth {  get; set; }
        public string month { get; set; }
        public string year { get; set; }

        public string result { get; set; }

        public HebrewDateModel(string day, string dayMonth, string month, string year, string result)
        {
            this.day = day;
            this.dayMonth = dayMonth;
            this.month = month;
            this.year = year;
            this.result = result;
        }
    }
}
