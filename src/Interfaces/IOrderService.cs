namespace DashboardPOC.Interfaces;

public interface IOrderService
{
    List<IDataValue> GetOrders();
    List<IDataValue> GetGroups();
}
