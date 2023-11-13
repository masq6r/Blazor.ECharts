using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Blazor.ECharts.Options;
using Blazor.ECharts.Options.Enum;

namespace Blazor.ECharts
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class JsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public JsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "/_content/Blazor.ECharts/core.js").AsTask());
        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        /// <summary>
        /// 初始化Echarts
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <param name="theme">主题</param>
        /// <returns></returns>
        public async ValueTask<IJSObjectReference> InitChart(string id, string theme = "light")
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            var module = await moduleTask.Value;
            return await module.InvokeAsync<IJSObjectReference>("echartsFunctions.initChart", id, theme);
        }
        public async Task RegisterMap(string name, string svg)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.registerMap", name, svg);
        }
        /// <summary>
        /// 配置Echarts参数
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <param name="theme">主题</param>
        /// <param name="option">参数</param>
        /// <returns></returns>
        public async Task SetupChart<T>(string id, string theme, EChartsOption<T> option, bool notMerge = false)
        {
            await SetupChart(id, theme, option.ToString(), new MergeOption());
        }

        public async Task SetupChart<T>(string id, string theme, EChartsOption<T> option, MergeOption mergeOpt)
        {
            await SetupChart(id, theme, option.ToString(), mergeOpt);
        }

        /// <summary>
        /// 配置Echarts参数
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <param name="theme">主题</param>
        /// <param name="option">参数</param>
        /// <returns></returns>
        public async Task SetupChart(string id, string theme, string option, bool notMerge = false)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            if (option == null) throw new ArgumentNullException(nameof(option), "echarts参数不能为空");
            if (string.IsNullOrWhiteSpace(theme)) theme = "light";
            var module = await moduleTask.Value;
            try
            {
                await module.InvokeVoidAsync("echartsFunctions.setupChart", id, theme, option, notMerge);
            }
            catch(Exception ex)
            {
                Console.WriteLine("id:" + id);
                Console.WriteLine($"{ex.Message}");
            }
        }

        public async Task SetupChart(string id, string theme, string option, MergeOption opt)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            if (option == null) throw new ArgumentNullException(nameof(option), "echarts参数不能为空");
            if (string.IsNullOrWhiteSpace(theme)) theme = "light";
            var module = await moduleTask.Value;
            var optString = EChartsOptionSerializer.Default.Serialize(opt);
            try
            {
                await module.InvokeVoidAsync("echartsFunctions.setupChart", id, theme, option, optString);
            }
            catch(Exception ex)
            {
                Console.WriteLine("id:" + id);
                Console.WriteLine($"{ex.Message}");
            }
        }

        public async Task DispatchAction(string id, EChartsDispatchAction act)
        {
            var module = await moduleTask.Value;
            var actString = EChartsOptionSerializer.Default.Serialize(act);
            try
            {
                await module.InvokeVoidAsync("echartsFunctions.dispatchAction", id, actString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("id:" + id);
                Console.WriteLine("action:" + actString);
                Console.WriteLine(ex);
            }
        }

        public async Task SetTheme<T>(string id, string theme, EChartsOption<T> option, MergeOption mergeOpt)
        {
            var module = await moduleTask.Value;
            var optString = EChartsOptionSerializer.Default.Serialize(option);
            var mergeString = EChartsOptionSerializer.Default.Serialize(mergeOpt);
            try
            {
                await module.InvokeVoidAsync("echartsFunctions.setTheme", id, theme, optString, mergeString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("id:" + id);
                Console.WriteLine(ex);
            }
        }

        public async Task RegisterThemes(IEnumerable<ThemeOption> themes)
        {
            var module = await moduleTask.Value;
            try
            {
                foreach (var theme in themes)
                {
                    var str = EChartsOptionSerializer.Default.Serialize(theme);
                    await module.InvokeVoidAsync("echartsFunctions.registerTheme", theme.ThemeName, str);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to register themes: \n" + ex);
            }
        }

        /// <summary>
        /// 自适应
        /// </summary>
        /// <param name="id">ECharts容器ID</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task Resize(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id), "echarts控件id不能为空");
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.resize", id);
        }

        public async Task ChartOn(string id, EventType eventType, DotNetObjectReference<EventInvokeHelper> objectReference)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("echartsFunctions.on", id, eventType.ToString(), objectReference);
        }
#nullable enable
        /// <summary>
        /// 透明传递
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async ValueTask InvokeVoidAsync(string identifier, params object?[] args)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync(identifier, args);
        }
#nullable disable

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
