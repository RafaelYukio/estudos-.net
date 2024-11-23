using MVCCleanArchitecture.Application.DTOs;
using MVCCleanArchitecture.Application.Interfaces;
using MVCCleanArchitecture.Domain.Interfaces.Services.Application;
using MVCCleanArchitecture.Domain.Interfaces.Services.OtherApplication;

namespace MVCCleanArchitecture.Application.Services
{
    public class DataItemService(ITransacaoService transacaoService,
                                 IStatusService statusService,
                                 IOtherTransacaoService otherTransacaoService,
                                 IOtherStatusService otherStatusService) : IDataItemService
    {
        private readonly ITransacaoService _transacaoService = transacaoService;
        private readonly IStatusService _statusService = statusService;
        private readonly IOtherTransacaoService _otherTransacaoService = otherTransacaoService;
        private readonly IOtherStatusService _otherStatusService = otherStatusService;

        public async Task<IEnumerable<DataItem>> GetDataItemByTransacaoIdAsync(int id)
        {
            var transacao = await _transacaoService.GetByIdAsync(id);
            var transacaoOutros = await _otherTransacaoService.GetByIdAsync(id);

            var dataItems = new List<DataItem>();

            if (transacao != null)
            {
                var databaseName = _transacaoService.GetDatabaseName();

                dataItems.Add(new DataItem
                {
                    Data = transacao,
                    Origem = $"Database - {databaseName}",
                    CreatedDate = transacao.CreatedDate
                });

                dataItems.AddRange(transacao.Status.Select(status => new DataItem
                {
                    Data = status,
                    Origem = $"Database - {databaseName}",
                    CreatedDate = status.CreatedDate
                }));
            }

            if (transacaoOutros != null)
            {
                var databaseName = _otherTransacaoService.GetDatabaseName();

                dataItems.Add(new DataItem
                {
                    Data = transacaoOutros,
                    Origem = $"Database - {databaseName}",
                    CreatedDate = transacao.CreatedDate
                });

                dataItems.AddRange(transacaoOutros.Status.Select(status => new DataItem
                {
                    Data = status,
                    Origem = $"Database - {databaseName}",
                    CreatedDate = status.CreatedDate
                }));
            }

            return dataItems.OrderByDescending(d => d.CreatedDate);
        }

        //public async Task<IEnumerable<DataItem>> GetDataItemsAsync()
        //{
        //    var transacoes = await _transacaoService.GetAllAsync();
        //    var status = await _statusService.GetAllAsync();

        //    var dataItems = new List<DataItem>();

        //    dataItems.AddRange(transacoes.Select(t => new DataItem
        //    {
        //        Data = t,
        //        Origem = "Database",
        //        CreatedDate = t.CreatedDate
        //    }));

        //    dataItems.AddRange(status.Select(t => new DataItem
        //    {
        //        Data = t,
        //        Origem = "Database",
        //        CreatedDate = t.CreatedDate
        //    }));

        //    return dataItems.OrderByDescending(d => d.CreatedDate);
        //}
    }
}
