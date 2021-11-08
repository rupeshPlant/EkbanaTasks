using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTableCreation.Model
{
    [Index("PersonId", "ContsctId", IsUnique = true)]

    public class PersonContact
        {
            //[Index(nameof(PersonId, ContactId), IsUnique = true)]
            public int PersonId { get; set; }
            public int ContactId { get; set; }

            [ForeignKey(nameof(PersonId))]
            public Person Person { get; set; }

            [ForeignKey(nameof(ContactId))]
            public ContactInfo Contact { get; set; }
        }
    }

