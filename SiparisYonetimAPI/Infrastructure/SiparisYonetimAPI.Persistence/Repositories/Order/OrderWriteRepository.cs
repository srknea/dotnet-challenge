using SiparisYonetimAPI.Application.Repositories;
using SiparisYonetimAPI.Domain.Entities;
using SiparisYonetimAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimAPI.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository

    {
        public OrderWriteRepository(SiparisYonetimAPIDbContext context) : base(context)
        {
        }
    }
}
