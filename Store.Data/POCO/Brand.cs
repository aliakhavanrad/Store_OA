using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.POCO
{
    public class Brand: BaseEntity
    {
        public string Name { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
