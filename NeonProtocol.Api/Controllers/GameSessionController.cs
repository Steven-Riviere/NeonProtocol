using Microsoft.AspNetCore.Mvc;
using NeonProtocol.Api.DTOs.GameSession;
using NeonProtocol.Api.Services.Interfaces;
using NeonProtocol.Api.Entities;


[ApiController]
[Route("api/[controller]")]
public class GameSessionController : ControllerBase
{
    private readonly IGameSessionService _gameSessionService;

    public GameSessionController(IGameSessionService gameSessionService)
    {
        _gameSessionService = gameSessionService;
    }

    [HttpPost]
      public async Task<ActionResult<GameSessionResponseDto>> Create(
        CreateGameSessionRequestDto request)
    {
        var gameSession = new GameSession
        {
            PlayerId = request.PlayerId,
            Score = request.Score,
            Kills = request.Kills,
            LevelReached = request.LevelReached,
            DamageTaken = request.DamageTaken,
            SurvivalTime = request.SurvivalTime,
            StageReached = request.StageReached,
            WaveReached = request.WaveReached
        };

        var createdGameSession = await _gameSessionService.CreateAsync(gameSession);
        
        var response = new GameSessionResponseDto
        {
            Id = createdGameSession.Id,
            Score = createdGameSession.Score,
            Kills = createdGameSession.Kills,
            LevelReached = createdGameSession.LevelReached,
            DamageTaken = createdGameSession.DamageTaken,
            SurvivalTime = createdGameSession.SurvivalTime,
            StageReached = createdGameSession.StageReached,
            WaveReached = createdGameSession.WaveReached,
            CreatedAt = createdGameSession.CreatedAt
        };

        return Ok(response);
    }
}