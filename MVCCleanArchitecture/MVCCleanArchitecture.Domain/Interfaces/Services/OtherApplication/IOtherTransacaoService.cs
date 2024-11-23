using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Services.Base;

namespace MVCCleanArchitecture.Domain.Interfaces.Services.OtherApplication
{
    public interface IOtherTransacaoService : IBaseService<Transacao>
    {
        Task<Transacao?> GetByIdAsync(int id);
        string GetDatabaseName();
    }
}
