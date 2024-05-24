using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProducer
{
    public class ClsMaterialCommodityMapping: BaseClass
    {
        [Key]
        public long CommodityCode { get; set; }
        public string MaterialType { get; set; }
        public decimal Price { get; set; }
        public decimal DutyPercentage { get; set; }
    }

    
}
