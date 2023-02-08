using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blazor.ECharts.Options.Enum;

namespace Blazor.ECharts.Options
{
    public class IconStyle
    {
        public double? BorderWidth { set; get; }

        public string Color { set; get; }
        public string BorderColor { set; get; }

        /// <summary>
        /// 线的类型。
        /// </summary>
        public LineStyleType? BorderType { set; get; }

    }
}
