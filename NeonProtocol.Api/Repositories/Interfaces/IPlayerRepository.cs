using NeonProtocol.Api.Entities;

namespace NeonProtocol.Api.Repositories.Interfaces;

public interface IPlayerRepository
{
    Task AddAsync(Player player);

    Task SaveChangesAsync();
}