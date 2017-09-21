using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DiscountService.Controllers
{
    [Route("api/[controller]")]
    public class DiscountController : Controller
    {
        // GET api/values
        [HttpGet]
        public Discount Get()
        {
            return DiscountService.GetDiscount();
        }

    }
}
