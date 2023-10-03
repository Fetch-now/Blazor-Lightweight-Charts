using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Series
{
    public class BaselineDataValue : SingleValueData
    {
        public string? TopFillColor1 { get; set; }
        public string? TopFillColor2 { get; set; }
        public string? TopLineColor { get; set; }
        public string? BottomFillColor1 { get; set; }    
        public string? BottomFillColor2 { get; set; }
        public string? BottomLineColor { get; set; }

        public BaselineDataValue(DateTime date, double value, string? topFillColor1, string? topFillColor2, string? topLineColor, string? bottomFillColor1, string? bottomFillColor2, string? bottomLinecColor) : base(date, value)
        {
            TopFillColor1 = topFillColor1;
            TopFillColor2 = topFillColor2;
            TopLineColor = topLineColor;
            BottomFillColor1 = bottomFillColor1;
            BottomFillColor2 = bottomFillColor2;
            BottomLineColor = bottomLinecColor;
        }
    }
}
