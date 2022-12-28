using SiparisYonetimAPI.Domain.Entities.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimAPI.Domain.Entities
{
    public class Firm : BaseEntity
    {  
        public string FirmaAdi { get; set; } = null!;
        public bool OnayDurumu { get; set; }
        public DateTime SiparisIzinBaslangicTarihi { get; set; }
        public DateTime SiparisIzinBitisTarihi { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
