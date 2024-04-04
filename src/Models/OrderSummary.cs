namespace DashboardPOC.Models;

public abstract class OrderSummary
{
    private readonly Random _random = new ();

    public abstract string Name { get; }
    public int Orders { get; set; }

    protected OrderSummary()
    {
        Orders = _random.Next(30, 100);
    }
}

public class HighlyDivertedOrderSummary : OrderSummary
{
    private const string HIGHLY_DIVERTED = @"Highly Diverted";
    
    public override string Name { get; } = HIGHLY_DIVERTED;

    public HighlyDivertedOrderSummary()
    {

    }
}

public class ControlledSubstanceOrderSummary : OrderSummary
{
    private const string CONTROLLED_SUBSTANCES = @"Controlled Substances";
    
    public override string Name { get; } = CONTROLLED_SUBSTANCES;

    public ControlledSubstanceOrderSummary()
    {

    }
}
