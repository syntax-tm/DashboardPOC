using DashboardPOC.Models;

namespace DashboardPOC.Interfaces;

public interface IOrderService
{
    List<OrderSummary> GetOrders();
    List<OrderSummary> GetControlledSubstanceOrders();
    List<OrderSummary> GetHighlyDivertedOrders();
}
