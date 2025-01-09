using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Slideshows
    {
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string? Image_url { get; set; }

        public DateTime Created_at { get; set; } = default;

        public DateTime? Updated_at { get; set; }

        public bool? Is_deleted { get; set; }

    }
}
