using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Lightweight_Charts.Model.Parameters.SeriesParametes
{
    public class SeriesOptionsCommon
    {
        public bool LastValueVisible { get; set; } = true;
        public string Title { get; set; } = string.Empty;
        public string? PriceScaleId { get; set; }
        public bool Visible { get; set; } = true;
        public bool PriceLineVisible { get; set; } = true;
        public PriceLineSource PriceLineSource { get; set; } = PriceLineSource.LastBar;
        public LineWidth PriceLineWidth { get; set; } = LineWidth._1;
        public string PriceLineColor { get; set; } = string.Empty;
        public LineStyle PriceLineStyle { get; set; } = LineStyle.Dashed;
        public bool BaseLineVisible { get; set; } = true;
        public string BaseLineColor { get; set; } = "#B2B5BE";
        public LineWidth BaseLineWidth { get; set; } = LineWidth._1;
        public LineStyle BaseLineStyle { get; set; } = LineStyle.Solid;
    }

    public enum PriceLineSource
    {
        LastBar = 0,
        LastVisible = 1
    }

    public enum LineWidth
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
    }

    public enum LineStyle
    {
        Solid = 0,
        Dotted = 1,
        Dashed = 2,
        LargeDashed = 3,
        SparseDotted = 4
    }
}
