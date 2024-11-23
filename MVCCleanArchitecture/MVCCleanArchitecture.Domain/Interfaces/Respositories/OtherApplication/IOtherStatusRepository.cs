using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Base;

namespace MVCCleanArchitecture.Domain.Interfaces.Respositories.OtherApplication
{
    public interface IOtherStatusRepository : IBaseRepository<Status>
    {
        Task<List<Status>> GetByTransacaoIdAsync(int id);
    }
}
