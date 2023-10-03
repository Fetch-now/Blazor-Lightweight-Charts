using Blazor_Lightweight_Charts.Model.Series;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Abstractions
{
    public abstract class SeriesComponent : ComponentBase
    {
        [CascadingParameter]
        public LightweightChart Chart { get; set; } = null!;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (Chart == null)
                {
                    throw new ArgumentNullException("Parent chart is not initialized");
                }

                while (!Chart.IsInitialized)
                {
                    await Task.Delay(25);
                }

                await Initialize();
            }
        }

        protected abstract Task Initialize();
    }
}
