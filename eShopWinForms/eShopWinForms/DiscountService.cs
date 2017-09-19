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

        public static async Task<Discount> GetDiscount()
        {
            //client.BaseAddress = new Uri("http://localhost:62283/");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("http://localhost:62283/api/discount");
            var discount = await response.Content.ReadAsAsync<Discount>();

            return discount;
        }
    }
}
