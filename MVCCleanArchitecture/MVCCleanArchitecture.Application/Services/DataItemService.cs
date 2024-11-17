using MVCCleanArchitecture.Application.DTOs;
using MVCCleanArchitecture.Application.Interfaces;
using MVCCleanArchitecture.Domain.Interfaces.Services;

namespace MVCCleanArchitecture.Application.Services
{
    public class DataItemService(ITransacaoService transacaoService,
                                 IStatusService statusService) : IDataItemService
    {
        private readonly ITransacaoService _transacaoService = transacaoService;
        private readonly IStatusService _statusService = statusService;

        public async Task<IEnumerable<DataItem>> GetDataItemsAsync()
        {
            var transacoes = await _transacaoService.GetAllAsync();
            var status = await _statusService.GetAllAsync();

            var dataItems = new List<DataItem>();

            dataItems.AddRange(transacoes.Select(t => new DataItem
            {
                Data = t,
                Origem = "Database",
                CreatedDate = t.CreatedDate
            }));

            dataItems.AddRange(status.Select(t => new DataItem
            {
                Data = t,
                Origem = "Database",
                CreatedDate = t.CreatedDate
            }));

            return dataItems.OrderByDescending(d => d.CreatedDate);
        }
    }
}
