using NeonProtocol.Api.Entities;
using NeonProtocol.Api.Repositories.Interfaces;
using NeonProtocol.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace NeonProtocol.Api.Services;

public class GameSessionService : IGameSessionService
{
    private readonly IGameSessionRepository _gameSessionRepository;

    public GameSessionService(IGameSessionRepository gameSessionRepository)
    {
        _gameSessionRepository = gameSessionRepository;
    }


    public async Task<GameSession> CreateAsync(GameSession gameSession)
    {
        await _gameSessionRepository.AddAsync(gameSession);
        await _gameSessionRepository.SaveChangesAsync();

        return gameSession;
    }

    public async Task<List<GameSession>> GetLeaderboardAsync(int limit)
    {
        if (limit <= 0)
        {
            limit = 10;
        }

        if (limit > 25)
        {
            limit = 25;
        }

        return await _gameSessionRepository.GetLeaderboardAsync(limit);
    }
}