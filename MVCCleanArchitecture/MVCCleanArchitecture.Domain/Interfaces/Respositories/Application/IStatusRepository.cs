using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Base;

namespace MVCCleanArchitecture.Domain.Interfaces.Respositories.Application
{
    public interface IStatusRepository : IBaseRepository<Status>
    {
        Task<List<Status>> GetByTransacaoIdAsync(int id);
    }
}
