using System;
using System.Collections.Generic;

namespace NorthwindManagerDb
{
    public partial class OrderDetail
    {
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public long Quantity { get; set; }
        public double Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
