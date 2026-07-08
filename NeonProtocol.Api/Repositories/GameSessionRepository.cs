using NeonProtocol.Api.Data;
using NeonProtocol.Api.Entities;
using NeonProtocol.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace NeonProtocol.Api.Repositories;

public class GameSessionRepository : IGameSessionRepository
{
    private readonly NeonProtocolDbContext _context;

    public GameSessionRepository(NeonProtocolDbContext context)
    {
        _context = context;
    }


    public async Task AddAsync(GameSession gameSession)
    {
        await _context.GameSessions.AddAsync(gameSession);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<List<GameSession>> GetLeaderboardAsync(int limit)
    {
        return await _context.GameSessions
            .Include(gs => gs.Player)
            .OrderByDescending(gs => gs.Score)
            .Take(limit)
            .ToListAsync();
    }
}