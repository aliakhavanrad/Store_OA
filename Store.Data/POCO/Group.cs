using System;
using System.Collections.Generic;

namespace Store.Data.POCO
{
    public class Group: BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public virtual IEnumerable<Product>  Products { get; set; }
        
    }
}
