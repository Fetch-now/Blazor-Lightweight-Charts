using Blazor_Lightweight_Charts.Model.Series;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Abstractions
{
    public abstract class SeriesComponent<TItem, TResult> : ComponentBase where TResult : TimeValueData
    {
        [CascadingParameter]
        public LightweightChart Chart { get; set; } = null!;

        [Parameter]
        public Func<TItem, DateTime> Date { get; set; } = null!;

        [Parameter]
        public IEnumerable<TItem> Items { get; set; } = new List<TItem>();

        public abstract string Invocation { get; }

        private List<TResult> _items = new List<TResult>();

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

        protected async Task Initialize()
        {
            foreach(TItem item in Items)
            {
                _items.Add((await MapItem(item)));
            }

            Chart.AddSeries(_items, Invocation);
        }

        protected abstract Task<TResult> MapItem(TItem item);
    }
}
