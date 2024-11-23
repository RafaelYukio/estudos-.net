using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Services.Base;

namespace MVCCleanArchitecture.Domain.Interfaces.Services.OtherApplication
{
    public interface IOtherStatusService : IBaseService<Status>
    {
        Task<List<Status>> GetByTransacaoIdAsync(int id);
    }
}
