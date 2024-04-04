namespace DashboardPOC.Models;

public class GroupData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal OrderTotal { get; set; }
    public int NumOrders { get; set; }
    public decimal AverageOrderPrice { get; set; }

    public GroupData(int id)
    {
        Id = id;

        Name = $"Group {Id}";
            
        OrderTotal = (decimal) Random.Shared.NextDouble() * 250000 + 15000;
        NumOrders = Random.Shared.Next(2500, 7000);
        AverageOrderPrice = Math.Round(OrderTotal / NumOrders, 2);
    }
}