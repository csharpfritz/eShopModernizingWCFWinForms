using System;
using System.Data.SqlClient;

namespace eShopServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CatalogService" in both code and config file together.
    public class CatalogService : ICatalogService
    {
        public string RemoveCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }

        public string UpdateCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }
   
        public string CreateCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }

        void ICatalogService.CreateCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }

        void ICatalogService.UpdateCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }

        void ICatalogService.RemoveCatalogItem(CatalogItem catalogItem)
        {
            throw new NotImplementedException();
        }
    }
}
