using System;
using System.Collections.Generic;

namespace SmartCart.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public string? Productname { get; set; }
        public string? Description { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? Orderid { get; set; }
        public int? Categoryid { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Order? Order { get; set; }
    }
}
