using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTableCreation.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public int PersonId { get; set; } //fk
        public int CustmerCode { get; set; }
        public string PurchaseHistory { get; set; }

        [ForeignKey("PersonId")]
        public Person MyProperty { get; set; }
    }
}
