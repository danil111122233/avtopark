using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark.DataAccess.Entities
{
    public class Order: BaseEntity
    {
        public DateTime BookBeginTime { get; set; }
        public DateTime BookEndTime { get; set; }
        public int Price { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int AutomobileId { get; set; }
        public Automobile Automobile { get; set; }
    }
}
