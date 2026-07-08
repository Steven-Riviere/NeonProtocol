using NeonProtocol.Api.Entities;

namespace NeonProtocol.Api.Services.Interfaces;

public interface IGameSessionService
{
    Task<GameSession> CreateAsync(GameSession gameSession);
}