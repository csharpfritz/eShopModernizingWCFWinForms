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
        IEnumerable<CatalogBrand> GetCatalogBrands();
        //[OperationContract]
        //PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize, int pageIndex);
        [OperationContract]
        IEnumerable<CatalogType> GetCatalogTypes();
        [OperationContract]
        void CreateCatalogItem(CatalogItem catalogItem);
        [OperationContract]
        void UpdateCatalogItem(CatalogItem catalogItem);
        [OperationContract]
        void RemoveCatalogItem(CatalogItem catalogItem);
    }

    [DataContract]
    public class CatalogItem
    {
        public const string DefaultPictureName = "dummy.png";

        public CatalogItem()
        {
            PictureFileName = DefaultPictureName;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public string PictureFileName { get; set; }

        [DataMember]
        public string PictureUri { get; set; }

        [DataMember]
        public int CatalogTypeId { get; set; }

        [DataMember]
        public CatalogType CatalogType { get; set; }

        [DataMember]
        public int CatalogBrandId { get; set; }

        [DataMember]
        public CatalogBrand CatalogBrand { get; set; }

        // Quantity in stock
        [DataMember]
        public int AvailableStock { get; set; }

        // Available stock at which we should reorder
        [DataMember]
        public int RestockThreshold { get; set; }

        // Maximum number of units that can be in-stock at any time (due to physicial/logistical constraints in warehouses)
        [DataMember]
        public int MaxStockThreshold { get; set; }

        /// <summary>
        /// True if item is on reorder
        /// </summary>
        [DataMember]
        public bool OnReorder { get; set; }
    }

    [DataContract]
    public class CatalogBrand
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Brand { get; set; }
    }

    [DataContract]
    public class CatalogType
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
    }
}
