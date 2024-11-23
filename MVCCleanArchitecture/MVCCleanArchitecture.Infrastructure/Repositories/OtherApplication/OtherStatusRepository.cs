using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.OtherApplication;
using MVCCleanArchitecture.Infrastructure.Data;
using MVCCleanArchitecture.Infrastructure.Repositories.Base;

namespace MVCCleanArchitecture.Infrastructure.Repositories.OtherApplication
{
    public class OtherStatusRepository(OtherApplicationDbContext context) : BaseRepository<Status>(context), IOtherStatusRepository
    {
        public async Task<List<Status>> GetByTransacaoIdAsync(int id)
        {
            return await _DbSet
                .Where(s => s.TransacaoID == id)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
