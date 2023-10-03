using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public abstract class TimeValueData
    {
        protected DateTime _date { get; set; }
        public long Time => ((DateTimeOffset)_date).ToUnixTimeSeconds();

        public TimeValueData(DateTime date) 
        {
            _date = date;
        }

        public TimeValueData(long timeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            _date = dateTime.AddSeconds(timeStamp).ToLocalTime();
        }
    }
}
