using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace eShopWCFService.Models
{
    [DataContract]
    public class DiscountItem
    {
        public DiscountItem()
        {
        }

        [DataMember]
        public double Size { get; set; }

        [DataMember]
        public DateTime Start { get; set; }

        [DataMember]
        public DateTime End { get; set; }
    }
}