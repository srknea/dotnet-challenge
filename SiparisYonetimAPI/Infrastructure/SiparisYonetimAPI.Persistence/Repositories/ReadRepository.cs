using Microsoft.EntityFrameworkCore;
using SiparisYonetimAPI.Application.Repositories;
using SiparisYonetimAPI.Domain.Entities.Common;
using SiparisYonetimAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly SiparisYonetimAPIDbContext _context;

        public ReadRepository(SiparisYonetimAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);
        public async Task<T> GetByIdAsync(string id)
            //=> await Table.FirstOrDefaultAsync(data => data.Id == int.Parse(id));
            => await Table.FindAsync(int.Parse(id));



    }
}
