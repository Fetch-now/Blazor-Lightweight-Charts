using Blazor_Lightweight_Charts.Model;
using Blazor_Lightweight_Charts.Model.Parameters.ChartParameters;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor_Lightweight_Charts
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class LightweighChartsInterop
    {
        private readonly IJSRuntime JS;

        public LightweighChartsInterop(IJSRuntime jsRuntime)
        {
            JS = jsRuntime;
        }

        public async Task<ChartApi> CreateChart(ElementReference reference, ChartOptions options)
        {
            var instance = await JS.InvokeAsync<IJSObjectReference>("LightweightCharts.createChart", reference, options);

            return new ChartApi(instance);
        }
    }
}
