using System;
using System.Collections.Generic;
using System.Text;

namespace dateModifier
{
    public class DateModifier
    {
        private DateTime firtsDate;
        private DateTime secondDate;
        public DateTime FirstDate { get; set; }
        public DateTime SecondDate { get; set; }

        public int GetDifferenceDays()
        {
            return Math.Abs((this.FirstDate.Date - this.SecondDate.Date).Days);
        }
    }
}
