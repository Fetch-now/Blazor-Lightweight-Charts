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

        public async Task AddSeries<T>(T[] items, string invocation) where T : TimeValueData
        {
            var series = await _jSInstance.InvokeAsync<IJSObjectReference>(invocation);
            await series.InvokeVoidAsync("setData", new object[] { items });
            
            var timeScale = await _jSInstance.InvokeAsync<IJSObjectReference>("timeScale");
            await timeScale.InvokeVoidAsync("fitContent");
        }
    }
}
