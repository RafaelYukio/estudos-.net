using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Base;

namespace MVCCleanArchitecture.Domain.Interfaces.Respositories.Application
{
    public interface ITransacaoRepository : IBaseRepository<Transacao>
    {
        Task<Transacao?> GetByIdAsync(int id);
        string GetDatabaseName();
    }
}
