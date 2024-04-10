using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components;

namespace DashboardPOC.Components;

public partial class BlazorComponentBase : ComponentBase, INotifyPropertyChanged
{
    

    protected BlazorComponentBase()
    {
        var properties = GetType().GetProperties(BindingFlags.Instance);
        var methods = GetType().GetMethods(BindingFlags.Instance);

        foreach (var prop in properties)
        {
            var propChangedMethod = methods.SingleOrDefault(m => m.Name.Equals($"On{prop.Name}Changed"));
            if (propChangedMethod == null) continue;
        }

    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;

        field = value;
        OnPropertyChanged(propertyName);
        StateHasChanged();
        return true;
    }
}
