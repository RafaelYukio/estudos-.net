using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.OtherApplication;
using MVCCleanArchitecture.Domain.Interfaces.Services.OtherApplication;
using MVCCleanArchitecture.Domain.Services.Base;

namespace MVCCleanArchitecture.Domain.Services.OtherApplication
{
    public class OtherStatusService(IOtherStatusRepository _statusRepository) : BaseService<Status>(_statusRepository), IOtherStatusService
    {
        public async Task<List<Status>> GetByTransacaoIdAsync(int id)
        {
            return await _statusRepository.GetByTransacaoIdAsync(id);
        }
    }
}
