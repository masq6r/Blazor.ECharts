using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    public record Series3DBase
    {
        public Series3DBase(string type, string id = null, string name = null)
        {
            Type = type;
            Id = id;
            Name = name;
        }

        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string Type { set; get; } = "line";

        /// <summary>
        /// 系列名称，用于tooltip的显示，legend 的图例筛选，在 setOption 更新数据和配置项时用于指定对应的系列。
        /// </summary>
        public string Name { set; get; }

        public string CoordinateSystem { set; get; } = "cartesian3D";

        /// <summary>
        /// 是否开启动画。
        /// </summary>
        public bool Animation { set; get; } = true;

        /// <summary>
        /// 过渡动画的时长。
        /// </summary>
        public double AnimationDurationUpdate { set; get; } = 500;

        /// <summary>
        /// 过渡动画的缓动效果。
        /// </summary>
        public string AnimationEasingUpdate { set; get; } = "cubicOut";

        /// <summary>
        /// 系列中的数据内容数组。数组项通常为具体的数据项。
        /// <para>点击<see href="https://www.echartsjs.com/zh/option.html#series-line.data ">此处</see>查看详细设置</para>
        /// </summary>
        public object Data { set; get; }

        /// <summary>
        /// 所有图形的 zlevel 值。
        /// <para>zlevel用于 Canvas 分层，不同zlevel值的图形会放置在不同的 Canvas 中，Canvas 分层是一种常见的优化手段。我们可以把一些图形变化频繁（例如有动画）的组件设置成一个单独的zlevel。需要注意的是过多的 Canvas 会引起内存开销的增大，在手机端上需要谨慎使用以防崩溃。</para>
        /// <para>zlevel 大的 Canvas 会放在 zlevel 小的 Canvas 的上面。</para>
        /// </summary>
        public int? Zlevel { set; get; }

        public int Grid3DIndex { set; get; } = 0;

        public int Geo3DIndex { set; get; } = 0;

        public int GlobeIndex { set; get; } = 0;

        public bool Silent { set; get; } = false;
    }
}
