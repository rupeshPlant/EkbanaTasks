using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTableCreation.Model
{
    [Index("PersonId", "CustomerId", IsUnique = true)]
    [Index()]
    public class PersonContactInfo
    {
        [Key]
        public int PersonContactInfoId { get; set; }
        public int PersonId { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
