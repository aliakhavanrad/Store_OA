using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.POCO
{
    public class Product : BaseEntity
    {
        public string ModelName { get; set; }
        public int GroupID { get; set; }
        public virtual Group Group { get; set; }
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
        public double Price { get; set; }
    }
}
