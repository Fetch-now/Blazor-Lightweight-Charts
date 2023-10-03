using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public class CandleStickDataValue : OHLCDataValue
    {
        public string? BorderColor { get; set; }
        public string? WickColor { get; set; }

        public CandleStickDataValue(DateTime date, double open, double high, double low, double close, string? color, string? borderColor, string? wickColor) : base(date, open, high, low, close, color)
        {
            BorderColor = borderColor;
            WickColor = wickColor;
        }
    }
}
