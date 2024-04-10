using ApexCharts;
using DashboardPOC.Interfaces;
using Microsoft.AspNetCore.Components;

namespace DashboardPOC.Components.Charts.Base;

public abstract partial class ChartComponentBase : ComponentBase
{
    public abstract ChartType Type { get; }

    public ApexChartOptions<IDataValue> Options { get; set; }
    public IList<IDataValue> SelectedValue { get; set; }
    public SelectedData<IDataValue> SelectedData { get; set; }

    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string ParentChartId { get; set; }
    
    [Parameter]
    public bool ShowDataLabels { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string GroupName { get; set; }
    
    // TODO: change Data to accept a collection of IDataValue (i.e. a series)
    [Parameter]
    public IList<IDataValue> Data { get; set; }
    
    [Parameter] public EventCallback<IList<IDataValue>> SelectedValueChanged { get; set; }
    [Parameter] public EventCallback<SelectedData<IDataValue>> SelectedDataChanged { get; set; }
    [Parameter] public EventCallback<bool> ShowDataLabelsChanged { get; set; }
    [Parameter] public EventCallback<bool> TitleChanged { get; set; }
    [Parameter] public EventCallback<bool> GroupNameChanged { get; set; }
}
