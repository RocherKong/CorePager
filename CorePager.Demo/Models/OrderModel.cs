using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePager.Demo.Models
{
    public class OrderModel
    {
        public String OrderNo { get; set; }

        public DateTime OrderTime { get; set; }

        public int OrderTotalAmount { get; set; }
    }
}
