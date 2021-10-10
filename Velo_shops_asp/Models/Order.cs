using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Velo_shops_asp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public int BakeId { get; set; }
        public string Contact { get; set; }
        public Velobake Velobake { get; set; }
    }
}
