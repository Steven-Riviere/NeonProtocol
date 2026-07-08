using Microsoft.EntityFrameworkCore;
using NeonProtocol.Api.Entities;

namespace NeonProtocol.Api.Data;

public class NeonProtocolDbContext : DbContext
{
    public NeonProtocolDbContext(DbContextOptions<NeonProtocolDbContext> options)
        : base(options)
    {
    }

    public DbSet<Player> Players => Set<Player>();
    public DbSet<GameSession> GameSessions => Set<GameSession>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(NeonProtocolDbContext).Assembly);
    }
}