using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.ECharts.Options
{
    /// <summary>
    /// 直角坐标系内绘图网格，单个 grid 内最多可以放置上下两个 X 轴，左右两个 Y 轴。可以在网格上绘制折线图，柱状图，散点图（气泡图）。
    /// </summary>
    public record Grid3D : IPosition
    {
        /// <summary>
        /// 组件 ID。默认不指定。指定则可用于在 option 或者 API 中引用组件。
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public bool? Show { set; get; }

        /// <summary>
        /// 所有图形的 zlevel 值。
        /// <para>zlevel用于 Canvas 分层，不同zlevel值的图形会放置在不同的 Canvas 中，Canvas 分层是一种常见的优化手段。我们可以把一些图形变化频繁（例如有动画）的组件设置成一个单独的zlevel。需要注意的是过多的 Canvas 会引起内存开销的增大，在手机端上需要谨慎使用以防崩溃。</para>
        /// <para>zlevel 大的 Canvas 会放在 zlevel 小的 Canvas 的上面。</para>
        /// </summary>
        public int? Zlevel { set; get; }

        /// <summary>
        /// 组件的所有图形的z值。控制图形的前后顺序。z值小的图形会被z值大的图形覆盖。
        /// <para>z相比zlevel优先级更低，而且不会创建新的 Canvas。</para>
        /// </summary>
        public int? Z { set; get; }

        /// <summary>
        /// 三维笛卡尔坐标系在三维场景中的深度。
        /// </summary>
        public object BoxDepth { set; get; }

        /// <summary>
        /// 三维笛卡尔坐标系在三维场景中的宽度。配合 viewControl.distance 可以得到最合适的展示尺寸。
        /// </summary>
        public object BoxWidth { set; get; }

        /// <summary>
        /// 三维笛卡尔坐标系在三维场景中的高度。
        /// </summary>
        public object BoxHeight { set; get; }

        /// <summary>
        /// 环境贴图。支持纯色、渐变色、全景贴图的 url。
        /// 默认为 'auto'，在配置有 light.ambientCubemap.texture 的时候会使用该纹理作为环境贴图。否则则不显示环境贴图。
        /// </summary>
        public object Environment { set; get; }

        /// <summary>
        /// 坐标轴轴线相关设置。
        /// </summary>
        public AxisLine AxisLine { set; get; }

        /// <summary>
        /// 坐标轴刻度标签的相关设置。
        /// </summary>
        public AxisLabel AxisLabel { set; get; }

        public AxisTick AxisTick { set; get; }

        public AxisPointer AxisPointer { set; get; }

        public SplitArea SplitArea { set; get; }

        /// <summary>
        /// 坐标轴在 grid 区域中的分隔线。
        /// </summary>
        public SplitLine SplitLine { set; get; }

        /// <summary>
        /// grid 组件离容器左侧的距离。
        /// <para>left 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'。</para>
        /// <para>如果 left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。</para>
        /// </summary>
        public object Left { set; get; }

        /// <summary>
        /// grid 组件离容器上侧的距离。
        /// <para>top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。</para>
        /// <para>如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。</para>
        /// </summary>
        public object Top { set; get; }

        /// <summary>
        /// grid 组件离容器右侧的距离。
        /// <para>right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。</para>
        /// </summary>
        public object Right { set; get; }

        /// <summary>
        /// grid 组件离容器下侧的距离。
        /// <para>bottom 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。</para>
        /// </summary>
        public object Bottom { set; get; }

        /// <summary>
        /// 图例组件的宽度。默认自适应。
        /// </summary>
        public object Width { set; get; }

        /// <summary>
        /// 图例组件的高度。默认自适应。
        /// </summary>
        public object Height { set; get; }
    }
}
