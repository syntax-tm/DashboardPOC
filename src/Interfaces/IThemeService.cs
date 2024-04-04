using ApexCharts;
using MudBlazor;

namespace DashboardPOC.Interfaces;

public interface IThemeService
{
    event Action OnIsDarkModeChange;

    bool IsDarkMode { get; set; }
    MudTheme Theme { get; set; }
    Theme ApexTheme { get; set; }
}
