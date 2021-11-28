using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo
{    
    public class Customer
    {
        [Column("CustomerId")]        
        public int Id { get; set; }

        [Column("CustomerName")]
        [Required]
        public string Name { get; set; }

        [Column("DateOfBirth")]
        public DateTime BirthDate { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
