using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public abstract class BarDataValue : OHLCDataValue
    {
        protected BarDataValue(DateTime date, double open, double high, double low, double close, string? color) : base(date, open, high, low, close, color)
        {
        }
    }
}
