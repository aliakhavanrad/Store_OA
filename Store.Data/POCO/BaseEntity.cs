using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.POCO
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
