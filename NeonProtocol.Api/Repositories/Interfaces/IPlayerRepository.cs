using NeonProtocol.Api.Entities;

namespace NeonProtocol.Api.Repositories.Interfaces;

public interface IPlayerRepository
{
    Task<Player?> GetByPseudoAsync(string pseudo);

    Task AddAsync(Player player);

    Task SaveChangesAsync();
}