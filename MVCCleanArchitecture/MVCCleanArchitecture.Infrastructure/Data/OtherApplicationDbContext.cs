using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Domain.Entities;

namespace MVCCleanArchitecture.Infrastructure.Data
{
    public class OtherApplicationDbContext(DbContextOptions<OtherApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Transacao> Transacao { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
