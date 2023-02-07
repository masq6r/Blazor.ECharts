using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public class DataZoom
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public bool Disabled { get; set; }
        public int[] XAxisIndex { get; set; }
        public int[] YAxisIndex { get; set; }
    }
}