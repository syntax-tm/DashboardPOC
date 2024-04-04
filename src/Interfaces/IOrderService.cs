using DashboardPOC.Models;

namespace DashboardPOC.Interfaces;

public interface IOrderService
{
    List<OrderSummary> GetOrders();
    List<GroupData> GetGroups();
}
