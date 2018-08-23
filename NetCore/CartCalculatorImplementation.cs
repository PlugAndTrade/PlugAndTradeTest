using System;
using System.Collections.Generic;

namespace PlugAndTradeTest
{
    public class CartCalculatorImplementation : ICartCalculator
    {
        private readonly ProductDatabase _productDatabase;

        public CartCalculatorImplementation(ProductDatabase productDatabase)
        {
            _productDatabase = productDatabase;
        }

        public IReadOnlyCollection<int> CalculateLeastDeliveries(IReadOnlyCollection<string> gtins)
        {
            // Alla artiklar med samma VendorId levereras tillsammans (gruppera produkterna på VendorId)
            // Hitta den kombination av produkter som ger så få leveranser som möjligt
            // Om flera kombinationer ger samma antal leveranser - gå på den billigaste kombinationen

            throw new NotImplementedException();
        }

        public IReadOnlyCollection<int> CalculateCheapest(IReadOnlyCollection<string> gtins)
        {
            // Totalt pris = summan av inköpspriset av alla produkter + den dyraste fraktkostnaden per leverantör (gruppera produkterna på VendorId)
            // Om flera kombinationer ger samma pris - välj den kombination som ger så få leveranser som möjligt

            throw new NotImplementedException();
        }

        public IReadOnlyCollection<int> CalculateFastestDeliveryTime(IReadOnlyCollection<string> gtins)
        {
            // Hitta kombinationen som gör att kunden får sina varor så snabbt som möjligt (summan av leveranstiden för alla artiklar).
            // Artiklar som har samma VendorId skickas alltid tillsammans - leveranstiden för gruppen blir Max(ExpectedDeliveryTimeInDays) (gruppera produkterna på VendorId).
            // Total leveranstid för artiklarna i en leverans blir alltså: antal artiklar i leveransen x leveranstiden för gruppen
            // Om flera kombinationer ger samma resultat - ta den billigaste kombinationen

            throw new NotImplementedException();
        }
    }
}