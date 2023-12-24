using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark.DataAccess.Entities
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public virtual ICollection<Automobile> Automobiles { get; set; }
    }
}
