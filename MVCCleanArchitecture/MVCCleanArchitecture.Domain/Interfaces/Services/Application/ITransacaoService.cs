﻿using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Services.Base;

namespace MVCCleanArchitecture.Domain.Interfaces.Services.Application
{
    public interface ITransacaoService : IBaseService<Transacao>
    {
        Task<Transacao?> GetByIdAsync(int id);
        string GetDatabaseName();
    }
}
