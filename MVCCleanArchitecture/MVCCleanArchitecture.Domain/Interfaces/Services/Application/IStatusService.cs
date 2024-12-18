﻿using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Services.Base;

namespace MVCCleanArchitecture.Domain.Interfaces.Services.Application
{
    public interface IStatusService : IBaseService<Status>
    {
        Task<List<Status>> GetByTransacaoIdAsync(int id);
    }
}
