using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopServiceLibrary.Models.Infrastructure
{
    public static class PreconfiguredData
    {
        public static List<CatalogItem> GetPreconfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem { Id =1, CatalogTypeId = 2, CatalogBrandId = 2, Description = ".NET Bot Black Hoodie", Name = ".NET Bot Black Hoodie", Price = 19.5M},
                new CatalogItem { Id =2, CatalogTypeId = 1, CatalogBrandId = 2, Description = ".NET Black & White Mug", Name = ".NET Black & White Mug", Price= 8.50M},
                new CatalogItem { Id =3, CatalogTypeId = 2, CatalogBrandId = 5, Description = "Prism White T-Shirt", Name = "Prism White T-Shirt", Price = 12},
                new CatalogItem { Id =4, CatalogTypeId = 2, CatalogBrandId = 2, Description = ".NET Foundation T-shirt", Name = ".NET Foundation T-shirt"},
                new CatalogItem { Id =5, CatalogTypeId = 3, CatalogBrandId = 5, Description = "Roslyn Red Sheet", Name = "Roslyn Red Sheet", Price = 8.5M},
                new CatalogItem { Id =6, CatalogTypeId = 2, CatalogBrandId = 2, Description = ".NET Blue Hoodie", Name = ".NET Blue Hoodie", Price = 12},
                new CatalogItem { Id =7, CatalogTypeId = 2, CatalogBrandId = 5, Description = "Roslyn Red T-Shirt", Name = "Roslyn Red T-Shirt", Price = 12},
                new CatalogItem { Id =8, CatalogTypeId = 2, CatalogBrandId = 5, Description = "Kudu Purple Hoodie", Name = "Kudu Purple Hoodie", Price = 8.5M },
                new CatalogItem { Id =9, CatalogTypeId = 1, CatalogBrandId = 5, Description = "Cup<T> White Mug", Name = "Cup<T> White Mug", Price = 12 },
                new CatalogItem { Id =10, CatalogTypeId = 3, CatalogBrandId = 2, Description = ".NET Foundation Sheet", Name = ".NET Foundation Sheet", Price = 12 },
                new CatalogItem { Id =11, CatalogTypeId = 3, CatalogBrandId = 2, Description = "Cup<T> Sheet", Name = "Cup<T> Sheet", Price = 8.5M },
                new CatalogItem { Id =12, CatalogTypeId = 2, CatalogBrandId = 5, Description = "Prism White TShirt", Name = "Prism White TShirt", Price = 12 },
            };
        }

        public static IEnumerable<CatalogBrand> GetPreconfiguredCatalogBrands()
        {
            return new List<CatalogBrand>()
            {
                new CatalogBrand() { Id =1, Brand = "Azure"},
                new CatalogBrand() { Id =2, Brand = ".NET" },
                new CatalogBrand() { Id =3, Brand = "Visual Studio" },
                new CatalogBrand() { Id =4, Brand = "SQL Server" },
                new CatalogBrand() { Id =5, Brand = "Other" }
            };
        }

        public static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType() { Id =1, Type = "Mug"},
                new CatalogType() { Id =2, Type = "T-Shirt" },
                new CatalogType() { Id =3, Type = "Sheet" },
                new CatalogType() { Id =4, Type = "USB Memory Stick" }
            };
        }

        public static IEnumerable<CatalogItemsStock> GetPreconfiguredCatalogItemsStock()
        {
            return new List<CatalogItemsStock>()
            {
                new CatalogItemsStock() {StockId=1, CatalogItemId=1, Date=new DateTime(2017, 9, 20), AvailableStock=100},
                new CatalogItemsStock() {StockId=2, CatalogItemId=1, Date=new DateTime(2017, 9, 21), AvailableStock=120},
                new CatalogItemsStock() {StockId=3, CatalogItemId=1, Date=new DateTime(2017, 9, 22), AvailableStock=80},
                new CatalogItemsStock() {StockId=4, CatalogItemId=2, Date=new DateTime(2017, 9, 20), AvailableStock=45},
                new CatalogItemsStock() {StockId=5, CatalogItemId=4, Date=new DateTime(2017, 9, 25), AvailableStock=65},
                new CatalogItemsStock() {StockId=6, CatalogItemId=5, Date=new DateTime(2017, 9, 28), AvailableStock=22}
            };
        }
    }
}