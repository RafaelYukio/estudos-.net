﻿using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Domain.Entities;
using MVCCleanArchitecture.Domain.Interfaces.Respositories;
using MVCCleanArchitecture.Infrastructure.Data;
using MVCCleanArchitecture.Infrastructure.Repositories.Base;

namespace MVCCleanArchitecture.Infrastructure.Repositories
{
    public class StatusRepository(ApplicationDbContext context) : BaseRepository<Status>(context), IStatusRepository
    {
        public async Task<List<Status>> GetByTransacaoIdAsync(int id)
        {
            return await _DbSet
                .Where(s => s.TransacaoID == id)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
