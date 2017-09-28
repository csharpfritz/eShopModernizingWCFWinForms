using eShopWinForms.eShopServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopWinForms.Controllers
{
    public delegate void ViewHandler<I
        >(ICatalogView sender, FilterEventArgs e);
    public delegate void AvailabilityHandler<ICatalogView>(ICatalogView sender, AvailabilityEventArgs e);
    public delegate void SearchStockHandler<ICatalogView>(ICatalogView sender, SearchStockEventArgs e);
    public class FilterEventArgs : EventArgs
    {
        public int typeFilterValue;
        public int brandFilterValue;
        public FilterEventArgs(int typeId, int brandId)
        {
            typeFilterValue = typeId;
            brandFilterValue = brandId;
        }
    }

    public class AvailabilityEventArgs : EventArgs
    {
        public int itemId;
        public int itemStock;
        public DateTime shipDate;

        public AvailabilityEventArgs(int id, int stock, DateTime ship)
        {
            itemId = id;
            itemStock = stock;
            shipDate = ship;

        }
    }

    public class SearchStockEventArgs : EventArgs
    {
        public int itemId;
        public DateTime date;

        public SearchStockEventArgs(int id, DateTime thisDate)
        {
            itemId = id;
            date = thisDate;

        }
    }

    public interface ICatalogView
    {
        event ViewHandler<ICatalogView> filterChanged;
        event AvailabilityHandler<ICatalogView> availabilityButtonClicked;
        event SearchStockHandler<ICatalogView> searchStockButtonClicked;

        void SetController(CatalogController controller);
        void SetCatalogItems(IEnumerable<CatalogItem> items, double discountVal);
        void SetDiscountBanner(String bannerText);
        void SetTypeFilter(Dictionary<int, string> typeFilters);
        void SetBrandFilter(Dictionary<int, string> brandFilter);
        void ClearGrid();
        void NotifyAvailabilityUpdated();
        void ShowStockAvailability(int stock);
        void SetShipmentView(IEnumerable<CatalogItem> items);
    }
}
