using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ReqModel
{
    public  class ConsumedRequest
    {
        public string email { get; set; }
        public string DeclarationId { get; set; }
        public string DeclarationType { get; set; }
        public string numberofdeclaration { get; set; }
        public string consigneeName { get; set; }
        public string consignorName { get; set; }
        public string payerName { get; set; }
        public string importCountry { get; set; }
        public string exportCountry { get; set; }
        public string expectedDateOfDelivery { get; set; }
        public string transportationMode { get; set; }
        public string totalcharges { get; set; }
        public List<GoodItemConsumeData> GoodsItems { get; set; }
        
    }

    public class produceddataReq
    {
        public string declarationType { get; set; }
        public string payedBy { get; set; }
        public string email { get; set; }
        public string date { get; set; }
        public string importCountry { get; set; }
        public string exportCountry { get; set; }
        public string consigneeTIN { get; set; }
        public string consignorTIN { get; set; }
        public string transportationMode { get; set; }
        public string payerTIN { get; set; }
        public List<GoodItemsForProduceData> declarationGoodItems { get; set; }
    }

    public class GoodItemsForProduceData
    {
        public int quantity {  get; set; }
        public int commodityCode {  get; set; }
    }

    public class GoodItemConsumeData
    {
        public int Quantity { get; set; }
        public string MaterialType { get; set; }
        public string Price { get; set; }
    }
}
