using System.Collections.Generic;
using System.Linq;

namespace PlugAndTradeTest
{
    public static class ProductExtensions
    {
        public static decimal TotalCost(this IReadOnlyCollection<IProduct> products) => products.Sum(p => p.PurchasePrice) + products.GroupBy(p => p.VendorId).Sum(g => g.Max(p => p.ShippingCost));
    }
}