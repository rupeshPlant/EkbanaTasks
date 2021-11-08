using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTableCreation.Model
{
    [Index("PersonId", "AddressId", IsUnique = true, Name = "PersonAddressUniqueKey")]

    public class PersonAddress
    {
        [Key]
        public int PersonAddressId { get; set; }
        public int PersonId { get; set; } //fk,uk
        public int AddressId { get; set; } //fk,uk

        [ForeignKey("PersonId")]
        public Person person { get; set; }

        [ForeignKey("AddressId")]
        public AddressTable Address { get; set; }
    }
}
