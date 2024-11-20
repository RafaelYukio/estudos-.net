using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories;
using MVCCleanArchitecture.Infrastructure.Data;
using MVCCleanArchitecture.Infrastructure.Repositories.Base;

namespace MVCCleanArchitecture.Infrastructure.Repositories
{
    public class TransacaoRepository(ApplicationDbContext context) : BaseRepository<Transacao>(context), ITransacaoRepository
    {
        public async Task<Transacao?> GetByIdAsync(int id)
        {
            return await _DbSet
                .Include(t => t.Status)
                .AsNoTracking()
                .FirstOrDefaultAsync(entity => entity.TransacaoID == id);
        }
    }
}
