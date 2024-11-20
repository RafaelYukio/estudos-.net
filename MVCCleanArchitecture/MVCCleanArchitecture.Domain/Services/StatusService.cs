using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories;
using MVCCleanArchitecture.Domain.Interfaces.Services;
using MVCCleanArchitecture.Domain.Services.Base;

namespace MVCCleanArchitecture.Domain.Services
{
    public class StatusService(IStatusRepository _statusRepository) : BaseService<Status>(_statusRepository), IStatusService
    {
        public async Task<List<Status>> GetByTransacaoIdAsync(int id)
        {
            return await _statusRepository.GetByTransacaoIdAsync(id);
        }
    }
}
