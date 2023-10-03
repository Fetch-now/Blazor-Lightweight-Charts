using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts
{
    public static class ServiceCollectionExtensions
    {
        public static void AddLightweightCharts(this IServiceCollection services)
        {
            services.AddScoped<LightweighChartsInterop>();
        }
    }
}
