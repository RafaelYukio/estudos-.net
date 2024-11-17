using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Domain.Entities;

namespace MVCCleanArchitecture.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Transacao> Transacao { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
