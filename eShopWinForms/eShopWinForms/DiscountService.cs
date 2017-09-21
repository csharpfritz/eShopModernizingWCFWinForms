using DiscountService;
using System;
using System.Collections.Generic;
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
            client.BaseAddress = new Uri("http://localhost:62283/");
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
