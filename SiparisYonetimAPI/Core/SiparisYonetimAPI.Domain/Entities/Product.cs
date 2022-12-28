using SiparisYonetimAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int FirmId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Firm Firm { get; set; }
    }
}
