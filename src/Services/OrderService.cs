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


    public List<OrderSummary> GetControlledSubstanceOrders()
    {
        return
        [
            new ControlledSubstanceOrderSummary(),
            new ControlledSubstanceOrderSummary()
        ];
    }

    public List<OrderSummary> GetHighlyDivertedOrders()
    {
        return
        [
            new HighlyDivertedOrderSummary(),
            new HighlyDivertedOrderSummary()
        ];
    }
}
