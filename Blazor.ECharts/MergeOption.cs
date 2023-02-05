using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts
{
    public class MergeOption
    {
        public bool NotMerge { get; set; }
        public IEnumerable<string> ReplaceMerge { get; set; }
        public bool LazyUpdate { get; set; }
    }
}
