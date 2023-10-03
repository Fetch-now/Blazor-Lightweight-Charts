using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public abstract class SingleValueData : TimeValueData
    {
        public double Value { get; set; }

        public SingleValueData(DateTime date, double value) : base(date)
        {
            Value = value;
        }

        public SingleValueData(long timestamp, double value) : base(timestamp)
        {
            Value = value;
        }
    }
}
