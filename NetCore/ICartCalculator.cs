using System.Collections.Generic;

namespace PlugAndTradeTest
{
    public interface ICartCalculator
    {
        IReadOnlyCollection<int> CalculateCheapest(IReadOnlyCollection<string> gtins);
        IReadOnlyCollection<int> CalculateFastestDeliveryTime(IReadOnlyCollection<string> gtins);
        IReadOnlyCollection<int> CalculateLeastDeliveries(IReadOnlyCollection<string> gtins);
    }
}