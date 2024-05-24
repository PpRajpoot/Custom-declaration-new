using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClsGoodsItem: BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsItemId { get; set; }
        public int DeclarationID { get; set; }
        public int Quantity { get; set; }
        public decimal DutyCharges { get; set; }
        public string CommodityCode { get; set; }
    }
}
