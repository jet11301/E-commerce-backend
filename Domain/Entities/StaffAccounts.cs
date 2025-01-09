using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class StaffAccounts
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

        public bool? Is_active { get; set; }

        public DateTime Created_at { get; set; } = default;
        public DateTime? updated_at { get; set; }   

        public bool? Is_deleted { get; set; }

        public ICollection<Slideshows>? Slideshows { get; set; }
    }
}
