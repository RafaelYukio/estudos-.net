using MVCCleanArchitecture.Domain.Services.Base;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.OtherApplication;
using MVCCleanArchitecture.Domain.Interfaces.Services.OtherApplication;

namespace MVCCleanArchitecture.Domain.Services.OtherApplication
{
    public class OtherTransacaoService(IOtherTransacaoRepository _transacaoRepository) : BaseService<Transacao>(_transacaoRepository), IOtherTransacaoService
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
