using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public class HistogramDataValue : SingleValueData
    {
        public string? Color { get; set; }

        public HistogramDataValue(DateTime date, double value, string? color) : base(date, value)
        {
            Color = color;
        }
    }
}
