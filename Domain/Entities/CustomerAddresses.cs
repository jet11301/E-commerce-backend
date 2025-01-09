using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomerAddresses
    {
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string? Address_line1 { get; set; }
        [MaxLength(100)]
        public string? Address_line2 { get;set; }
        [MaxLength(6)]
        public string? Postal_code { get; set; }
        [MaxLength(50)]
        public string? Country { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        [MaxLength(11)]
        public string? Phone_number { get; set; }
        public Customers Customers { get; set; }

    }
}
