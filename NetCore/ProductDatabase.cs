using System;
using System.Collections.Generic;
using System.Linq;

namespace PlugAndTradeTest
{
    public class ProductDatabase
    {
        private readonly IReadOnlyCollection<IProduct> _products;

        public ProductDatabase()
        {
            _products = new IProduct[]
            {
                new Product
                {
                    Id = 1,
                    GTIN = "10001",
                    VendorId = "Lev1",
                    PurchasePrice = 500,
                    ShippingCost = 50,
                    ExpectedDeliveryTimeInDays = 4
                },
                new Product
                {
                    Id = 2,
                    GTIN = "10001",
                    VendorId = "Lev2",
                    PurchasePrice = 550,
                    ShippingCost = 100,
                    ExpectedDeliveryTimeInDays = 3
                },
                new Product
                {
                    Id = 3,
                    GTIN = "10001",
                    VendorId = "Lev3",
                    PurchasePrice = 450,
                    ShippingCost = 0,
                    ExpectedDeliveryTimeInDays = 8
                },

                new Product
                {
                    Id = 4,
                    GTIN = "10002",
                    VendorId = "Lev1",
                    PurchasePrice = 800,
                    ShippingCost = 500,
                    ExpectedDeliveryTimeInDays = 5
                },
                new Product
                {
                    Id = 5,
                    GTIN = "10002",
                    VendorId = "Lev2",
                    PurchasePrice = 750,
                    ShippingCost = 1000,
                    ExpectedDeliveryTimeInDays = 5
                },

                new Product
                {
                    Id = 6,
                    GTIN = "10003",
                    VendorId = "Lev1",
                    PurchasePrice = 75,
                    ShippingCost = 30,
                    ExpectedDeliveryTimeInDays = 1
                },
                new Product
                {
                    Id = 7,
                    GTIN = "10003",
                    VendorId = "Lev3",
                    PurchasePrice = 75,
                    ShippingCost = 50,
                    ExpectedDeliveryTimeInDays = 2
                }
            };
        }

        public class Product : IProduct
        {
            public int Id { get; set; }
            public string GTIN { get; set; }
            public string VendorId { get; set; }
            public decimal PurchasePrice { get; set; }
            public int ExpectedDeliveryTimeInDays { get; set; }
            public decimal ShippingCost { get; set; }
        }

        public IReadOnlyCollection<IProduct> GetProductsByGTIN(string gtin)
        {
            return _products
                .Where(p => string.Equals(p.GTIN, gtin, StringComparison.InvariantCultureIgnoreCase))
                .ToArray();
        }
    }
}
