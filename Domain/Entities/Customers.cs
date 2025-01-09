using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customers
    {
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string? FirstName { get; set; }
        [MaxLength(100)]
        public string? LastName { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? Password { get; set; }
        [MaxLength(255)]
        public string? Profile_img { get; set; }
        public bool? Is_locked { get; set; } = true;
        public DateTime Created_at { get; set; } = default;
        public DateTime? Updated_at { get; set; }
        public bool? Is_deleted { get; set; } = false;
        public CustomerAddresses Customer_addresses { get; set; }
    }
}
