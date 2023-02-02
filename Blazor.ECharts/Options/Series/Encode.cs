using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options.Series
{
    public class Encode
    {
        public object X { get; set; }
        public object Y { get; set; }
        public List<string> Tooltip { get; set; }
        public List<object> SeriesName { get; set; }
        public int ItemId { get; set; }
        public int ItemGroupId { get; set; }
        public string ItemName { get; set; }
    }
}
