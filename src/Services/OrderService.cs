using DashboardPOC.Interfaces;
using DashboardPOC.Models;

namespace DashboardPOC.Services;

public class OrderService : IOrderService
{
    public List<IDataValue> GetOrders()
    {
        return
        [
            new DataValue(@"High Risk", 0, 150),
            new DataValue(@"Controlled Substances", 0, 200)
        ];
    }

    public List<IDataValue> GetGroups()
    {
        const int MIN = 50;
        const int MAX = 1000;

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
