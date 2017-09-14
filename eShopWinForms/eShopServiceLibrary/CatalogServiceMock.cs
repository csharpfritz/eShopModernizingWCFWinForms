using eShopServiceLibrary.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopServiceLibrary
{
    public class CatalogServiceMock : ICatalogService
    {
        private List<CatalogItem> catalogItems;
        private List<CatalogBrand> catalogBrands;
        private List<CatalogType> catalogTypes;

        public CatalogServiceMock()
        {
            catalogItems = new List<CatalogItem>(PreconfiguredData.GetPreconfiguredCatalogItems());
            catalogBrands = new List<CatalogBrand>(PreconfiguredData.GetPreconfiguredCatalogBrands());
            catalogTypes = new List<CatalogType>(PreconfiguredData.GetPreconfiguredCatalogTypes());
        }

        /*public PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize = 10, int pageIndex = 0)
        {
            var items = ComposeCatalogItems(catalogItems);

            var itemsOnPage = items
                .OrderBy(c => c.Id)
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToList();

            return new PaginatedItemsViewModel<CatalogItem>(
                pageIndex, pageSize, items.Count, itemsOnPage);
        }*/

        public CatalogItem FindCatalogItem(int id)
        {
            return catalogItems.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<CatalogItem> GetCatalogItems()
        {
            return catalogItems;
        }

        public IEnumerable<CatalogType> GetCatalogTypes()
        {
            return PreconfiguredData.GetPreconfiguredCatalogTypes();
        }

        public IEnumerable<CatalogBrand> GetCatalogBrands()
        {
            return PreconfiguredData.GetPreconfiguredCatalogBrands();
        }

        public void CreateCatalogItem(CatalogItem catalogItem)
        {
            var maxId = catalogItems.Max(i => i.Id);
            catalogItem.Id = ++maxId;
            catalogItems.Add(catalogItem);
        }

        public void UpdateCatalogItem(CatalogItem modifiedItem)
        {
            var originalItem = FindCatalogItem(modifiedItem.Id);
            if (originalItem != null)
            {
                catalogItems[catalogItems.IndexOf(originalItem)] = modifiedItem;
            }
        }

        public void RemoveCatalogItem(CatalogItem catalogItem)
        {
            catalogItems.Remove(catalogItem);
        }

        public void Dispose()
        {
        }

        private List<CatalogItem> ComposeCatalogItems(List<CatalogItem> items)
        {
            var catalogTypes = PreconfiguredData.GetPreconfiguredCatalogTypes();
            var catalogBrands = PreconfiguredData.GetPreconfiguredCatalogBrands();
            items.ForEach(i => i.CatalogBrand = catalogBrands.First(b => b.Id == i.CatalogBrandId));
            items.ForEach(i => i.CatalogType = catalogTypes.First(b => b.Id == i.CatalogTypeId));

            return items;
        }

        List<CatalogBrand> ICatalogService.GetCatalogBrands()
        {
            return catalogBrands;
        }

        List<CatalogType> ICatalogService.GetCatalogTypes()
        {
            return catalogTypes;
        }

        List<CatalogItem> ICatalogService.GetCatalogItems()
        {
            throw new NotImplementedException();
        }
    }
}