using Blazor.ECharts.Options.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Heatmap
{
    public record Heatmap : SeriesBase
    {
        public Heatmap() : base("heatmap") { }
        public CoordinateSystem CoordinateSystem { get; set; }
        public ItemStyle ItemStyle { set; get; }
        public Tooltip Tooltip {set; get; }
        public Label Label { set; get; }
        public Emphasis Emphasis { set; get; }
    }
}
