using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ClsCompany:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int companyId { get; set; }
        public long TIN { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int AddressID { get; set; }
    }
}
