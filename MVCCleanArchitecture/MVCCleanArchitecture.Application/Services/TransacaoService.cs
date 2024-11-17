using MVCCleanArchitecture.Application.Services.Base;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories;
using MVCCleanArchitecture.Domain.Interfaces.Services.Base;

namespace MVCCleanArchitecture.Application.Services
{
    public class TransacaoService(ITransacaoRepository transacaoRepository) : BaseService<Transacao>(transacaoRepository), ITransacaoService
    {
    }
}
