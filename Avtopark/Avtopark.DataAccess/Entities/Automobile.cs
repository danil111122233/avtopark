using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark.DataAccess.Entities
{
    public class Automobile:BaseEntity
    {
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int AutomobileCategoryId { get; set; }
        public AutomobileCategory AutomobileCategory { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
