using Microsoft.EntityFrameworkCore;
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


    public async Task<Player?> GetByPseudoAsync(string pseudo)
    {
        return await _context.Players
            .FirstOrDefaultAsync(p => p.Pseudo == pseudo);
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