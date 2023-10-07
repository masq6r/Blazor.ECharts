using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Candlestick
{
    /// <summary>
    /// K线图
    /// </summary>
    public record Candlestick : SeriesBase
    {
        public Candlestick() : base("candlestick") { }

        public ItemStyle ItemStyle { set; get; }

        public Tooltip Tooltip { set; get; }

        public MarkLine MarkLine { set; get; }

        public MarkPoint MarkPoint { set; get; }

        public Encode Encode { set; get; }

        public List<Dimension> Dimensions { set; get; }

        /// <summary>
        /// 使用的 x 轴的 index，在单个图表实例中存在多个 x 轴的时候有用。
        /// </summary>
        public int? XAxisIndex { set; get; }

        /// <summary>
        /// 使用的 y 轴的 index，在单个图表实例中存在多个 y轴的时候有用。
        /// </summary>
        public int? YAxisIndex { set; get; }
    }
}
