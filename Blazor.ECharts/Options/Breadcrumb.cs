using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record Breadcrumb
    {
        public bool Show {  get; set; }
        public object Left { get; set; }
        public object Right { get; set; }
        public object Top { get; set; }
        public object Bottom { get; set; }
        public object Height { get; set; }
    }
}
