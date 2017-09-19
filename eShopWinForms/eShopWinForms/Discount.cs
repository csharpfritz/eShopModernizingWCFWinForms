using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountService
{
    public class Discount
    {
        public Discount(double size, DateTime ends)
        {
            Size = size;
            Ends = ends;
        }

        public double Size { get; private set; }

        public DateTime Ends { get; private set; }
    }
}
