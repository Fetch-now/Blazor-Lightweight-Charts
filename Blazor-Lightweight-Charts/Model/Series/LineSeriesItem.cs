using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public class LineSeriesItem : SingleValueData
    {
        public LineSeriesItem(DateTime date, double value) : base(date, value) {}
    }
}
