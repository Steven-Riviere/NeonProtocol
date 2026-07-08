using NeonProtocol.Api.Entities;

namespace NeonProtocol.Api.Repositories.Interfaces;

public interface IGameSessionRepository
{
    Task AddAsync(GameSession gameSession);

    Task SaveChangesAsync();
}