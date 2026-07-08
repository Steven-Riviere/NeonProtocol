using NeonProtocol.Api.Entities;

namespace NeonProtocol.Api.Services.Interfaces;

public interface IPlayerService
{
    Task<Player> GetOrCreateAsync(string pseudo);
}