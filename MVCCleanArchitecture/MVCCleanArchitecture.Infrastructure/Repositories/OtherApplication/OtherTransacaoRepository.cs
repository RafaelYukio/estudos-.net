using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.OtherApplication;
using MVCCleanArchitecture.Infrastructure.Data;
using MVCCleanArchitecture.Infrastructure.Repositories.Base;

namespace MVCCleanArchitecture.Infrastructure.Repositories.OtherApplication
{
    public class OtherTransacaoRepository(OtherApplicationDbContext context) : BaseRepository<Transacao>(context), IOtherTransacaoRepository
    {
        public async Task<Transacao?> GetByIdAsync(int id)
        {
            return await _DbSet
                .Include(t => t.Status)
                .AsNoTracking()
                .FirstOrDefaultAsync(entity => entity.TransacaoID == id);
        }

        public string GetDatabaseName()
        {
            return _context.Database.GetDbConnection().Database;
        }
    }
}
