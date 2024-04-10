using ApexCharts;
using DashboardPOC.Components.Charts.Base;
using MudBlazor;

namespace DashboardPOC;

public static class ChartOptionsFactory
{
    private const string FORMAT_LOWERCASE = @"function (value) { if (value === undefined) { return ''; } return value.toLowerCase(); }";
    private const string FORMAT_UPPERCASE = @"function (value) { if (value === undefined) { return ''; } return value.toUpperCase(); }";
    private const string FORMAT_TITLECASE = @"function (value) { if (value === undefined) { return ''; } return value.split(' ').map(w => w[0].toUpperCase() + w.substring(1).toLowerCase()).join(' ');";
    private const string FORMAT_NUMBER = @"function(value, opts) { return  Number(value).toLocaleString(); }";
    private const string FORMAT_PERCENT = @"function(value, opts) { return  Math.round(Number(value)) + '%'; }";

    private const string FORMAT_USD = "function (value) { if (value === undefined) { return ''; } return Intl.NumberFormat('en-US', { style: 'currency', currency: 'USD' }).format(value); }";
    private const string FORMAT_GBP = "function (value) { if (value === undefined) { return ''; } return Intl.NumberFormat('en-GB', { style: 'currency', currency: 'GBP' }).format(value); }";
    private const string FORMAT_EUR = "function (value) { if (value === undefined) { return ''; } return Intl.NumberFormat('de-DE', { style: 'currency', currency: 'EUR' }).format(value); }";

    public static ApexChartOptions<T> CreateBarChartOptions<T>(ChartComponentBase component, bool horizontal = false) where T : class
    {
        var brush = !string.IsNullOrEmpty(component.ParentChartId)
            ? new Brush
            {
                Enabled = true,
                Target = component.ParentChartId
            }
            : null;

        var chart = new Chart
        {
            Id = component.Id,
            //Toolbar = brush == null
            //    ? null
            //    : new Toolbar
            //    {
            //        AutoSelected = AutoSelected.Selection
            //    },
            Group = component.GroupName,
            //Brush = brush
        };

        var options = new ApexChartOptions<T>
        {
            Chart = chart,
            Theme = new ()
            {
                Mode = Mode.Light,
                Palette = PaletteType.Palette1
            },
            PlotOptions = new ()
            {
                Bar = new ()
                {
                    Horizontal = horizontal
                }
            },
            Legend = new ()
            {
                Position = LegendPosition.Bottom
            }
        };

        return options;
    }

    public static ApexChartOptions<T> CreateDonutOptions<T>(ChartComponentBase component) where T : class
    {
        var options = new ApexChartOptions<T>
        {
            Chart = new ()
            {
                Id = component.Id,
                Toolbar = new ()
                {
                    AutoSelected = AutoSelected.Selection
                }
            },
            DataLabels = new ()
            {
                Formatter = FORMAT_PERCENT,
                Style = new ()
                {
                    Colors = [ @"#000" ]
                }
            },
            PlotOptions = new ()
            {
                Pie = new ()
                {
                    Donut = new ()
                    {
                        //Labels = new ()
                        //{
                        //    Show = true,
                        //    Name = new ()
                        //    {
                        //        Show = true
                        //    },
                        //    Value = new ()
                        //    {
                        //        Show = true
                        //    }
                        //}
                    }
                }
            }
        };

        return options;
    }
}
