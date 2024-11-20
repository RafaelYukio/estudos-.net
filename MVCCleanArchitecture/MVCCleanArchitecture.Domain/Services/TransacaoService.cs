using MVCCleanArchitecture.Domain.Services.Base;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories;
using MVCCleanArchitecture.Domain.Interfaces.Services;

namespace MVCCleanArchitecture.Domain.Services
{
    public class TransacaoService(ITransacaoRepository _transacaoRepository) : BaseService<Transacao>(_transacaoRepository), ITransacaoService
    {
        public async Task<Transacao?> GetByIdAsync(int id)
        {
            return await _transacaoRepository.GetByIdAsync(id);
        }
    }
}
