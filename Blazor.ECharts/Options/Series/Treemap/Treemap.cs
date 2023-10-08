using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series.Treemap
{
    public record Treemap : SeriesBase
    {
        public Treemap() : base("treemap") { }
        public Breadcrumb Breadcrumb { get; set; }
        public object Roam {set; get; }
        public object NodeClick {set; get; }
        public object Left {set; get; }
        public object Right {set; get; }
        public object Top {set; get; }
        public object Bottom {set; get; }
        public object Width {set; get; }
        public object Height {set; get; }
        public object Levels {set; get; }
        public Tooltip Tooltip {set; get; }
    }
}
