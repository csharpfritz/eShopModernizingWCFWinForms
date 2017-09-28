using System.Collections.Generic;
using System.Net;
using eShopWinForms.eShopServiceReference;
using System;

namespace eShopWinForms.Controllers
{
    public class CatalogController
    {
        private ICatalogService _service;
        private ICatalogView _view;

        public CatalogController(ICatalogService service, ICatalogView view)
        {
            this._service = service;
            this._view = view;
            this._view.filterChanged += new ViewHandler<ICatalogView>(this.filterChanged);
            this._view.availabilityButtonClicked += new AvailabilityHandler<ICatalogView>(this.addAvailability);
            this._view.searchStockButtonClicked += new SearchStockHandler<ICatalogView>(this.searchStockAvailable);
        }

        private void filterChanged(ICatalogView view, FilterEventArgs e)
        {
            LoadCatalogItems(e.brandFilterValue, e.typeFilterValue);
        }

        private void addAvailability(ICatalogView view, AvailabilityEventArgs e)
        {
            CatalogItemsStock shipment = new CatalogItemsStock();
            shipment.CatalogItemId = e.itemId;
            shipment.AvailableStock = e.itemStock;
            shipment.Date = e.shipDate;

            _service.CreateAvailableStock(shipment);
            _view.NotifyAvailabilityUpdated();
        }

        private void searchStockAvailable(ICatalogView view, SearchStockEventArgs e)
        {
            int res = _service.GetAvailableStock(e.date, e.itemId);

            _view.ShowStockAvailability(res);
        }

        /*
         * Queries the service to see if a discount is running for today. If so, it will update the view's discount banner
         */
        private void CheckForDiscounts()
        {
            double discountPercentage = 0;
            DiscountItem discount = _service.GetDiscount(DateTime.Now);
            if (discount != null)
            {
                discountPercentage = Math.Round(discount.Size * 100, 0);
                String bannerText = String.Format("{0}% sale endson {1}!", discountPercentage.ToString(), discount.End.ToShortDateString());
                _view.SetDiscountBanner(bannerText);
            }
        }

        public void LoadCatalogItems(int brandIdFilter, int typeIdFilter)
        {
            _view.ClearGrid();
            IEnumerable<CatalogItem> items = _service.GetCatalogItems(brandIdFilter, typeIdFilter);
            double discountVal = 0;
            DiscountItem discount = _service.GetDiscount(DateTime.Now);
            if (discount != null)
                discountVal = discount.Size;

            _view.SetCatalogItems(items, discountVal);
        }

        private void LoadBrandFilters()
        {
            //Fetch the list of catalog item brands
            IEnumerable<CatalogBrand> brands = _service.GetCatalogBrands();

            // Bind combobox to dictionary
            Dictionary<int, string> brandDictionary = new Dictionary<int, string>();

            //The service does not return an 'all' item by default, so we must add it.
            brandDictionary.Add(0, "All");

            // Add rest of type filters
            foreach (var catalogBrand in brands)
            {
                int idValue = catalogBrand.Id;
                string typeValue = catalogBrand.Brand;
                brandDictionary.Add(idValue, typeValue);
            }

            _view.SetBrandFilter(brandDictionary);
        }

        private void LoadTypeFilters()
        {
            //Fetch the list of catalog item types
            IEnumerable<CatalogType> types = _service.GetCatalogTypes();

            // Bind combobox to dictionary
            Dictionary<int, string> typeDictionary = new Dictionary<int, string>();

            //The service does not return an 'all' item by default, so we must add it.
            typeDictionary.Add(0, "All");

            // Add rest of type filters
            foreach (var catalogtype in types)
            {
                int idValue = catalogtype.Id;
                string typeValue = catalogtype.Type;
                typeDictionary.Add(idValue, typeValue);
            }

            _view.SetTypeFilter(typeDictionary);
        }

        public void LoadView()
        {
            _view.SetController(this);
            CheckForDiscounts();
            LoadCatalogItems(0, 0);
            LoadBrandFilters();
            LoadTypeFilters();
        }
    }
}
