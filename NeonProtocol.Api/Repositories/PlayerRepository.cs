using NeonProtocol.Api.Data;
using NeonProtocol.Api.Entities;
using NeonProtocol.Api.Repositories.Interfaces;

namespace NeonProtocol.Api.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly NeonProtocolDbContext _context;

    public PlayerRepository(NeonProtocolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Player player)
    {
        await _context.Players.AddAsync(player);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}