using System.Collections.Generic;
using System.Net;
using eShopWinForms.Models;
using eShopWinForms.Services;

namespace eShopWinForms.Controllers
{
    public class CatalogController
    {
        private ICatalogService service;

        public CatalogController(ICatalogService service)
        {
            this.service = service;
        }

        // GET /[?pageSize=3&pageIndex=10]
        public void Index(int pageSize = 10, int pageIndex = 0)
        {
        }

        // GET: Catalog/Details/5
        public void Details(int? id)
        {
        }

        // GET: Catalog/Create
        public void Create()
        {
        }

        public void Create(CatalogItem catalogItem)
        {
        }

        // GET: Catalog/Edit/5
        public void Edit(int? id)
        {
        }

        public void Edit(CatalogItem catalogItem)
        {
        }

        // GET: Catalog/Delete/5
        public void Delete(int? id)
        { 
        }

        public void DeleteConfirmed(int id)
        {
        }

        protected void Dispose(bool disposing)
        {
        }

        private void ChangeUriPlaceholder(IEnumerable<CatalogItem> items)
        {
            foreach (var catalogItem in items)
            {
                AddUriPlaceHolder(catalogItem);
            }
        }

        private void AddUriPlaceHolder(CatalogItem item)
        {
        }
    }
}
