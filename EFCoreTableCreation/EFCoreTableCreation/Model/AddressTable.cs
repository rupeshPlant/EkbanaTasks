using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTableCreation.Model
{
    public class AddressTable
    {
        [Key]
        public int AddressId { get; set; }
        public string Address { get; set; }
    }
}
