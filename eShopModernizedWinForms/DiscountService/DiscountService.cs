using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountService
{
    public class DiscountService
    {
        public static Discount GetDiscount()
        {
            double price = 0.2;
            DateTime start = DateTime.Today;
            DateTime end = DateTime.Today.AddDays(14);

            var discount = new Discount(price, start, end);
            return discount;
        }
    }
}
