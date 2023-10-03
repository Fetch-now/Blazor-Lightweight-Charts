using Blazor_Lightweight_Charts.Model.Series;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Abstractions
{
    public abstract class SingleValueSeriesComponent<TItem, TResult> : SeriesComponent<TItem, TResult> where TResult : SingleValueData
    {
        [Parameter]
        public Func<TItem, double> Value { get; set; } = null!;
    }
}
