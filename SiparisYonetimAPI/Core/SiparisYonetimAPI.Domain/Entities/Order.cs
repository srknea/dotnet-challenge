using SiparisYonetimAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int FirmId { get; set; }
        public int ProductId { get; set; }
        public string? SiparisVerenKisiAdi { get; set; }
        public DateTime SiparisTarihi { get; set; }

        public Firm Firm { get; set; }
        public Product Product { get; set; }
    }
}
