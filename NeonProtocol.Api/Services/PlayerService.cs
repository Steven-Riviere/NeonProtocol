using NeonProtocol.Api.Entities;
using NeonProtocol.Api.Repositories.Interfaces;
using NeonProtocol.Api.Services.Interfaces;

namespace NeonProtocol.Api.Services;

public class PlayerService : IPlayerService
{
    private readonly IPlayerRepository _playerRepository;

    public PlayerService(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }


    public async Task<Player> CreateAsync(string pseudo)
    {
        pseudo = pseudo.Trim();


        var player = new Player
        {
            Pseudo = pseudo
        };


        await _playerRepository.AddAsync(player);
        await _playerRepository.SaveChangesAsync();


        return player;
    }
}