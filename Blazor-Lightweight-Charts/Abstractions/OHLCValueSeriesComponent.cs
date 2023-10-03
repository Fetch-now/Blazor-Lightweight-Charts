using Blazor_Lightweight_Charts.Model.Series;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Abstractions
{
    public abstract class OHLCValueSeriesComponent<TItem, TResult> : SeriesComponent<TItem, TResult> where TResult : OHLCDataValue
    {
        [Parameter]
        public Func<TItem, double> Open { get; set; } = null!;
        [Parameter]
        public Func<TItem, double> High { get; set; } = null!;
        [Parameter]
        public Func<TItem, double> Low { get; set; } = null!;
        [Parameter]
        public Func<TItem, double> Close { get; set; } = null!;
    }
}
