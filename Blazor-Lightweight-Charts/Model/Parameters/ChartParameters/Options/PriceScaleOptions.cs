using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Parameters.ChartParameters.Options
{
    public class PriceScaleOptions
    {
        public bool InvertScale { get; set; } = false;
        public bool AlignLabels { get; set; } = true;
        public PriceScaleMode Mode { get; set; } = PriceScaleMode.Normal;
        public PriceScaleMargins ScaleMargins { get; set; } = new PriceScaleMargins()
        {
            Bottom = 0.1d,
            Top = 0.2d
        };

        public bool BorderVisisble { get; set; } = true;
        public string BorderColor { get; set; } = "#2B2B43";
        public string? TextColor { get; set; }
        public bool Visible { get; set; }
        public bool TicksVisible { get; set; } = false;
    }

    public enum PriceScaleMode
    {
        Normal = 0,
        Logarithmic = 1,
        Percentage = 2,
        IndextedTo100 = 3
    }

    public class PriceScaleMargins
    {
        private double _top { get; set; }
        private double _bottom { get; set; }
        public double Top
        {
            get => _top;
            set
            {
                if (value >= 0 && value < 1)
                    _top = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public double Bottom
        {
            get => _bottom;
            set
            {
                if (value >= 0 && value < 1)
                    _bottom = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
    }
}
