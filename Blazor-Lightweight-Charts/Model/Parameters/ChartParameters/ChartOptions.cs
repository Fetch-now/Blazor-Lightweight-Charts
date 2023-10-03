using Blazor_Lightweight_Charts.Model.Parameters.ChartParameters.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Parameters.ChartParameters
{
    public class ChartOptions
    {
        public double Height { get; set; } = 0;
        public double Width { get; set; } = 0;
        public bool Autosize { get; set; } = false;

        public PriceScaleOptions LeftPriceScale { get; set; } = new PriceScaleOptions()
        {
            Visible = false
        };

        public PriceScaleOptions RightPriceScale { get; set; } = new PriceScaleOptions()
        {
            Visible = true
        };
    }
}
