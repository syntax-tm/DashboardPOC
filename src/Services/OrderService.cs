using DashboardPOC.Interfaces;
using DashboardPOC.Models;

namespace DashboardPOC.Services;

public class OrderService : IOrderService
{
    public List<OrderSummary> GetOrders()
    {
        return
        [
            new (@"Highly Diverted"),
            new (@"Controlled Substances")
        ];
    }
}
