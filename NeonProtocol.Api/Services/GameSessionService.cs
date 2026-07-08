using NeonProtocol.Api.Entities;
using NeonProtocol.Api.Repositories.Interfaces;
using NeonProtocol.Api.Services.Interfaces;

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
}