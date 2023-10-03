using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public class AreaSeriesItem : SingleValueData
    {
        public string? LineColor { get; set; }
        public string? TopColor { get; set; }
        public string? BottomColor { get; set; }

        public AreaSeriesItem(DateTime date, double value) : base(date, value) {}
    }
}
