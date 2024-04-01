namespace DashboardPOC.Models;
public class OrderSummary
{
    private readonly Random _random = new ();

    public string Name { get; set; }
    public int HighlyDivertedOrders { get; set; }
    public int ControlledSubstanceOrders { get; set; }

    public OrderSummary(string name)
    {
        Name = name;

        HighlyDivertedOrders = _random.Next(30, 100);
        ControlledSubstanceOrders = _random.Next(20, 150);

    }
}