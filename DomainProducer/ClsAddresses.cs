using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProducer
{
    public class ClsAddresses: BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AddressID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int pincode { get; set; }
    }
}
