using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTableCreation.Model
{
    [Index("EmployeeCode",IsUnique =true)]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int PersonId { get; set; } //fk
        public int EmployeeCode { get; set; } //uk

        [Column(TypeName = "decimal(18,4)")] // NOTE : for decimal type always use this
        public decimal Salary { get; set; } // This will store 18 digits in the
                                            // database with 4 of those after the decimal.
        public double JoinedDate { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}
