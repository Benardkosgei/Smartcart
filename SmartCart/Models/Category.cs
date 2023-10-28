using System;
using System.Collections.Generic;

namespace SmartCart.Models
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string? Categoryname { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
