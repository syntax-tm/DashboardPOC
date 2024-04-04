using DashboardPOC.Interfaces;
using DashboardPOC.Models;

namespace DashboardPOC.Services;

public class OrderService : IOrderService
{
    public List<OrderSummary> GetOrders()
    {
        return
        [
            new HighlyDivertedOrderSummary(),
            new ControlledSubstanceOrderSummary()
        ];
    }

    public List<GroupData> GetGroups()
    {
        return
        [
            new (1),
            new (2),
            new (3),
            new (4),
            new (5),
            new (6),
            new (7),
            new (8)
        ];
    }
}
