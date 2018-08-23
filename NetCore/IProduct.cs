namespace PlugAndTradeTest
{
    public interface IProduct
    {
        int Id { get; }
        string GTIN { get; }
        string VendorId { get; }
        decimal PurchasePrice { get; }
        int ExpectedDeliveryTimeInDays { get; }
        decimal ShippingCost { get; }
    }
}