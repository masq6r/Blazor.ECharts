using Blazor.ECharts.Options.Series;
using Blazor.ECharts.Options.Series.Bar;
using Blazor.ECharts.Options.Series.Candlestick;
using Blazor.ECharts.Options.Series.Funnel;
using Blazor.ECharts.Options.Series.Gauge;
using Blazor.ECharts.Options.Series.Graph;
using Blazor.ECharts.Options.Series.Line;
using Blazor.ECharts.Options.Series.Map;
using Blazor.ECharts.Options.Series.Pie;
using Blazor.ECharts.Options.Series.Sankey;
using Blazor.ECharts.Options.Series.Scatter;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Blazor.ECharts.Options
{
    public class AxesThemeOption
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public bool AxisLineShow { get; set; }
        public string AxisLineColor { get; set; }
        public bool AxisTickShow { get; set; }
        public string AxisTickColor { get; set; }
        public bool AxisLabelShow { get; set; }
        public string AxisLabelColor { get; set; }
        public bool SplitLineShow { get; set; }
        public string[] SplitLineColor { get; set; }
        public bool SplitAreaShow { get; set; }
        public string[] SplitAreaColor { get; set; }
    }

    public class ThemeContent
    {
        public int SeriesCnt { get; set; }
        public string BackgroundColor { get; set; }
        public string TitleColor { get; set; }
        public string SubtitleColor { get; set; }
        public string TextColor { get; set; }
        public bool TextColorShow { get; set; }
        public string MarkTextColor { get; set; }
        public string[] Color { get; set; }
        public string BorderColor { get; set; }
        public int BorderWidth { get; set; }
        public string[] VisualMapColor { get; set; }
        public string LegendTextColor { get; set; }
        public string KColor { get; set; }
        public string KColor0 { get; set; }
        public string KBorderColor { get; set; }
        public string KBorderColor0 { get; set; }
        public int LineWidth { get; set; }
        public int SymbolSize { get; set; }
        public string Symbol { get; set; }
        public int SymbolBorderWidth { get; set; }
        public bool LineSmooth { get; set; }
        public int GraphLineWidth { get; set; }
        public string GraphLineColor { get; set; }
        public string MapLabelColor { get; set; }
        public string MapLabelColorE { get; set; }
        public string MapBorderColor { get; set; }
        public string MapBorderColorE { get; set; }
        public double MapBorderWidth { get; set; }
        public int MapBorderWidthE { get; set; }
        public string MapAreaColor { get; set; }
        public string MapAreaColorE { get; set; }
        public bool AxisSeperateSetting { get; set; }
        public string ToolboxColor { get; set; }
        public string ToolboxEmphasisColor { get; set; }
        public string TooltipAxisColor { get; set; }
        public int TooltipAxisWidth { get; set; }
        public string TimelineLineColor { get; set; }
        public int TimelineLineWidth { get; set; }
        public string TimelineItemColor { get; set; }
        public string TimelineItemColorE { get; set; }
        public string TimelineCheckColorE { get; set; }
        public string TimelineCheckBorderColorE { get; set; }
        public int TimelineItemBorderWidth { get; set; }
        public string TimelineControlColor { get; set; }
        public string TimelineControlBorderColor { get; set; }
        public double TimelineControlBorderWidth { get; set; }
        public string TimelineLabelColor { get; set; }
        public string DatazoomBackgroundColor { get; set; }
        public string DatazoomDataColor { get; set;}
        public string DatazoomFillColor { get; set;}
        public string DatazoomHandleColor { get; set;}
        public string DatazoomLabelColor { get; set;}
        public int DatazoomHandleWidth { get; set;}
        public AxesThemeOption[] Axis { get; set; }
    }

    public class ThemeOption
    {
        //public int Version { get; set; }
        public string ThemeName { get; set; }
        //public ThemeContent Theme { get; set; }
        public IEnumerable<string> Color { get; set; }
        public string BackgroundColor { get; set; }
        public TextStyle TextStyle { get; set; }
        public Title Title { get; set; }
        public Line Line { get; set; }
        public Radar Radar { get; set; }
        public Bar Bar { get; set; }
        public Pie Pie { get; set; }
        public Scatter Scatter { get; set; }
        public Sankey Sankey { get; set; }
        public Funnel Funnel { get; set; }
        public Gauge Gauge { get; set; }
        public Candlestick Candlestick { get; set; }
        public Graph Graph { get; set; }
        public Map Map { get; set; }
        public Axis CategoryAxis { get; set; }
        public Axis ValueAxis { get; set; }
        public Axis LogAxis { get; set; }
        public Axis TimeAxis { get; set; }
        public Toolbox Toolbox { get; set; }
        public Legend Legend { get; set; }
        public Tooltip Tooltip { get; set; }
        public DataZoom DataZoom { get; set; }
        public MarkPoint MarkPoint { get; set; }
    }
}
