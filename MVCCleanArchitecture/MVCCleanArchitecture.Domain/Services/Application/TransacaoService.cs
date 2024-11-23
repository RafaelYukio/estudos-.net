using MVCCleanArchitecture.Domain.Services.Base;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Application;
using MVCCleanArchitecture.Domain.Interfaces.Services.Application;

namespace MVCCleanArchitecture.Domain.Services.Application
{
    public class TransacaoService(ITransacaoRepository _transacaoRepository) : BaseService<Transacao>(_transacaoRepository), ITransacaoService
    {
        public async Task<Transacao?> GetByIdAsync(int id)
        {
            return await _transacaoRepository.GetByIdAsync(id);
        }

        public string GetDatabaseName()
        {
            return _transacaoRepository.GetDatabaseName();
        }
    }
}
