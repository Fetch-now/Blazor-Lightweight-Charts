using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public abstract class OHLCDataValue : TimeValueData
    {
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public string? Color { get; set; }

        public OHLCDataValue(DateTime date, double open, double high, double low, double close, string? color) : base(date)
        {
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Color = color;
        }
    }
}
