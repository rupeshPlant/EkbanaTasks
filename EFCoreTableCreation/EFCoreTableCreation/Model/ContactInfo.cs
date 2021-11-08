using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTableCreation.Model
{
    public class ContactInfo
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactInformation { get; set; }
    }
}
