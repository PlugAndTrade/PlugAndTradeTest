using System.Linq;
using Xunit;

namespace PlugAndTradeTest
{
    public class Tests
    {
        private static ICartCalculator CreateCartCalculator()
        {
            return new CartCalculatorImplementation(new ProductDatabase());
        }

        [Fact]
        public void CalculateLeastDeliveriesTest()
        {
            var cartCalculator = CreateCartCalculator();
            var result = cartCalculator.CalculateLeastDeliveries(new[] { "10001", "10002", "10003" });

            Assert.True(result.OrderBy(x => x).SequenceEqual(new[] { 1, 4, 6 }));
        }

        [Fact]
        public void CalculateCheapestTest()
        {
            var cartCalculator = CreateCartCalculator();
            var result = cartCalculator.CalculateCheapest(new[] { "10001", "10002", "10003" });

            Assert.True(result.OrderBy(x => x).SequenceEqual(new[] { 3, 4, 6 }));
        }

        [Fact]
        public void CalculateLolTest()
        {
            var cartCalculator = CreateCartCalculator();
            var result = cartCalculator.CalculateFastestDeliveryTime(new[] { "10001", "10002", "10003" });

            Assert.True(result.OrderBy(x => x).SequenceEqual(new[] { 2, 4, 7 }));
        }
    }
}
