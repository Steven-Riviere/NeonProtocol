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

    [HttpGet("leaderboard")]
    public async Task<ActionResult<List<LeaderboardEntryDto>>> GetLeaderboard()
    {
        var gameSessions = await _gameSessionService.GetLeaderboardAsync(10);

        var leaderboard = gameSessions.Select(gs => new LeaderboardEntryDto
        {
            Pseudo = gs.Player.Pseudo,
            Score = gs.Score,
            LevelReached = gs.LevelReached,
            CreatedAt = gs.CreatedAt
        }).ToList();

        return Ok(leaderboard);
    }
}