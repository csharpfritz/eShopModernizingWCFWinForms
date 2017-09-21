using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountService
{
    public class Discount
    {
        public Discount(double size, DateTime start, DateTime end)
        {
            Size = size;
            Start = start;
            End = end;
        }

        public double Size { get; private set; }

        public DateTime Start { get; private set; }

        public DateTime End { get; private set; }
    }
}
