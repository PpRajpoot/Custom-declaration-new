using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GoodItem: BaseClass
    {
        public int Quantity { get; set; }
        public string MaterialType { get; set; }
        public double Price { get; set; }
    }
}
