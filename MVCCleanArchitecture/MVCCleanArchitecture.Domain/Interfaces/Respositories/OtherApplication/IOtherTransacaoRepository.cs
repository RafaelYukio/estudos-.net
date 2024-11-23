using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Base;

namespace MVCCleanArchitecture.Domain.Interfaces.Respositories.OtherApplication
{
    public interface IOtherTransacaoRepository : IBaseRepository<Transacao>
    {
        Task<Transacao?> GetByIdAsync(int id);
        string GetDatabaseName();
    }
}
