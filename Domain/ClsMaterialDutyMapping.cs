using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClsMaterialDutyMapping: BaseClass
    {
        [Key]
        public long CommodityCode { get; set; }
        public decimal DutyPercentage { get; set; }
    }
}
