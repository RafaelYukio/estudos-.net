using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Application;
using MVCCleanArchitecture.Domain.Interfaces.Services.Application;
using MVCCleanArchitecture.Domain.Services.Base;

namespace MVCCleanArchitecture.Domain.Services.Application
{
    public class StatusService(IStatusRepository _statusRepository) : BaseService<Status>(_statusRepository), IStatusService
    {
        public async Task<List<Status>> GetByTransacaoIdAsync(int id)
        {
            return await _statusRepository.GetByTransacaoIdAsync(id);
        }
    }
}
