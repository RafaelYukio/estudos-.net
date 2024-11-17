using MVCCleanArchitecture.Domain.Services.Base;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories;
using MVCCleanArchitecture.Domain.Interfaces.Services;

namespace MVCCleanArchitecture.Domain.Services
{
    public class TransacaoService(ITransacaoRepository transacaoRepository) : BaseService<Transacao>(transacaoRepository), ITransacaoService
    {
    }
}
