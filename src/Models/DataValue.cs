using DashboardPOC.Interfaces;

namespace DashboardPOC.Models;

public class DataValue : IDataValue
{
    public string Name { get; set; }
    public decimal Value { get; set; }

    public DataValue()
    {

    }

    public DataValue(string name, decimal value)
    {
        Name = name;
        Value = value;
    }

    public DataValue(string name, int min, int max)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
        if (max < min) throw new ArgumentOutOfRangeException(nameof(max));

        Name = name;

        var value = Random.Shared.Next(min, max);

        Value = value;
    }

    public DataValue(string name, double min, double max, int precision = 2)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
        if (max < min) throw new ArgumentOutOfRangeException(nameof(max));

        Name = name;

        var range = max - min;
        var value = (Random.Shared.NextDouble() * range) + min;
        var rounded = Math.Round(value, precision);

        Value = (decimal) rounded;
    }
}
