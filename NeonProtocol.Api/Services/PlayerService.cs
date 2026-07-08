using NeonProtocol.Api.Entities;
using NeonProtocol.Api.Services.Interfaces;
using NeonProtocol.Api.Repositories.Interfaces;

public class PlayerService : IPlayerService
{
    private readonly IPlayerRepository _playerRepository;

    public PlayerService(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    public async Task<Player> GetOrCreateAsync(string pseudo)
    {
        var existingPlayer = await _playerRepository.GetByPseudoAsync(pseudo);
        if (existingPlayer != null)
        {
            return existingPlayer;
        }

        var player = new Player
        {
            Pseudo = pseudo
        };

        await _playerRepository.AddAsync(player);
        await _playerRepository.SaveChangesAsync();

        return player;
    }
}