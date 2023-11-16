using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Scatter3D
{
    /// <summary>
    /// 散点图
    /// </summary>
    public record Scatter3D : Series3DBase
    {
        public Scatter3D() : base("scatter3D") { }
        public ItemStyle ItemStyle { set; get; }
        public string Symbol { set; get; } = "circle";
        public int SymbolSize { set; get; } = 10;
        public object Label { set; get; }
        public Emphasis Emphasis { set; get; }
    }
}
