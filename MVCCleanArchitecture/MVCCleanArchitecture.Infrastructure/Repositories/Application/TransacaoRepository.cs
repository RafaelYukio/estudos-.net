using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Application;
using MVCCleanArchitecture.Infrastructure.Data;
using MVCCleanArchitecture.Infrastructure.Repositories.Base;

namespace MVCCleanArchitecture.Infrastructure.Repositories.Application
{
    public class TransacaoRepository(ApplicationDbContext context) : BaseRepository<Transacao>(context), ITransacaoRepository
    {
        public string GetDatabaseName()
        {
            return _context.Database.GetDbConnection().Database;
        }

        public async Task<Transacao?> GetByIdAsync(int id)
        {
            return await _DbSet
                .Include(t => t.Status)
                .AsNoTracking()
                .FirstOrDefaultAsync(entity => entity.TransacaoID == id);
        }
    }
}
