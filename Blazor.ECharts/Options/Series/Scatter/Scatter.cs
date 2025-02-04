using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Scatter
{
    /// <summary>
    /// 散点图
    /// </summary>
    public record Scatter : SeriesBase
    {
        public Scatter() : base("scatter") { }
        public ItemStyle ItemStyle { set; get; }
        public Tooltip Tooltip {set; get; }
        public string Symbol { set; get; } = "circle";
        public int SymbolSize { set; get; } = 10;
        public Emphasis Emphasis { set; get; }
    }
}
