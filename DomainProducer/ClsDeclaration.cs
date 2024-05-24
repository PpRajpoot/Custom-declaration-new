using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProducer
{
    public class ClsDeclaration: BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DeclarationId { get; set; }= Guid.NewGuid();
        public string DeclarationType { get; set; }
        public long payerTin { get; set; }
        public long consigneeTin { get; set; }
        public long consignerTin { get; set; }
        public string ImportCountry { get; set; }
        public string ExportCountry { get; set;}
        public DateTime Date { get; set; }
        public string transportationMode { get; set; }
        public DateTime expectedDateOfDelivery { get; set; }
        public decimal totalCharges { get; set; }
        

    }
}
