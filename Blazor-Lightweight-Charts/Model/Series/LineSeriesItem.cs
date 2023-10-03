using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public class LineSeriesItem
    {
        private DateTime _date { get; set; }
        public double Value { get; set; }
        public string Time => _date.ToString("yyyy-MM-dd");
    
        public LineSeriesItem(DateTime date, double value)
        {
            _date = date;
            Value = value;
        }
    }
}
