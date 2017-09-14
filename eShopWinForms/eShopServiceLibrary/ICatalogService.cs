using eShopServiceLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eShopServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICatalogService : IDisposable
    {
        [OperationContract]
        CatalogItem FindCatalogItem(int id);
        [OperationContract]
        List<CatalogBrand> GetCatalogBrands();
       // [CollectionDataContract]
      //  PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize, int pageIndex);
        [OperationContract]
        List<CatalogType> GetCatalogTypes();
        [OperationContract]
        void CreateCatalogItem(CatalogItem catalogItem);
        [OperationContract]
        void UpdateCatalogItem(CatalogItem catalogItem);
        [OperationContract]
        void RemoveCatalogItem(CatalogItem catalogItem);
    }
}
