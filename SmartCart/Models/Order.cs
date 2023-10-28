using System;
using System.Collections.Generic;

namespace SmartCart.Models
{
    public partial class Order
    {
        public Order()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Orderdate { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
