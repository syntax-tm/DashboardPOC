using DashboardPOC.Interfaces;
using DashboardPOC.Models;

namespace DashboardPOC.Services;

public class OrderService : IOrderService
{
    public List<IDataValue> GetOrders()
    {
        return
        [
            new DataValue(@"Highly Diverted", 20, 100),
            new DataValue(@"Controlled Substances", 40, 125)
        ];
    }

    public List<IDataValue> GetGroups()
    {
        const int MIN = 2500;
        const int MAX = 7000;

        return
        [
            new DataValue(@"Group 1", MIN, MAX),
            new DataValue(@"Group 2", MIN, MAX),
            new DataValue(@"Group 3", MIN, MAX),
            new DataValue(@"Group 4", MIN, MAX),
            new DataValue(@"Group 5", MIN, MAX),
            new DataValue(@"Group 6", MIN, MAX),
            new DataValue(@"Group 7", MIN, MAX),
            new DataValue(@"Group 8", MIN, MAX),
        ];
    }
}
