using ApexCharts;
using DashboardPOC.Interfaces;
using MudBlazor;

namespace DashboardPOC.Services;

public class ThemeService : IThemeService
{
    private bool _isDarkMode;

    public bool IsDarkMode
    {
        get => _isDarkMode;
        set
        {
            if (_isDarkMode == value) return;

            _isDarkMode = value;

            OnIsDarkModeChanged();
        }
    }

    public MudTheme Theme { get; set; }
    public Theme ApexTheme { get; set; }

    private void OnIsDarkModeChanged()
    {
        ApexTheme = new ()
        {
            Mode = IsDarkMode ? Mode.Dark : Mode.Light,
            Palette = PaletteType.Palette1
        };

        NotifyIsDarkModeChanged();
    }
    
    public event Action OnIsDarkModeChange;
    private void NotifyIsDarkModeChanged() => OnIsDarkModeChange?.Invoke();
}
