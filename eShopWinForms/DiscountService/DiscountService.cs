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
            var discount = new Discount(0.1, new DateTime().AddDays(10));
            return discount;
        }
    }
}
