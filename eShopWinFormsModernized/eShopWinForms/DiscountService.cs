using DiscountService;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace eShopWinForms
{
    public class DiscountService
    {
        static HttpClient client = new HttpClient();

        public static Discount GetDiscount()
        {
            // Get the AppSettings section.
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            string addr = appSettings["DiscountServiceAddress"];

            client.BaseAddress = new Uri(addr);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync("/api/discount").Result;
            Discount discount = null;

            if (response.IsSuccessStatusCode)
            {
                discount = response.Content.ReadAsAsync<Discount>().Result;
            }

            return discount;
        }
    }
}
