using Microsoft.AspNetCore.Mvc;
using NeonProtocol.Api.DTOs.Player;
using NeonProtocol.Api.Services.Interfaces;

namespace NeonProtocol.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
    private readonly IPlayerService _playerService;

    public PlayerController(IPlayerService playerService)
    {
        _playerService = playerService;
    }


    [HttpPost]
    public async Task<ActionResult<PlayerResponseDto>> Create(
        CreatePlayerRequestDto request)
    {
        var player = await _playerService.CreateAsync(request.Pseudo);


        var response = new PlayerResponseDto
        {
            Id = player.Id,
            Pseudo = player.Pseudo,
            CreatedAt = player.CreatedAt
        };


        return Ok(response);
    }
}