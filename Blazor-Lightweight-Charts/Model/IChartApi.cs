using Blazor_Lightweight_Charts.Model.Series;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model
{
    public class ChartApi
    {
        private readonly IJSObjectReference _jSInstance;

        public ChartApi(IJSObjectReference jSInstance)
        {
            _jSInstance = jSInstance;
        }

        public async Task AddLineSeries(LineSeriesItem[] items)
        {
            var lineSeries = await _jSInstance.InvokeAsync<IJSObjectReference>("addLineSeries");
            await lineSeries.InvokeVoidAsync("setData", new object[] { items });
        }
    }
}
