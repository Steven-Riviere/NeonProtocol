using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using NeonProtocol.Api.Data;
using Microsoft.OpenApi.Models;
using NeonProtocol.Api.Repositories;
using NeonProtocol.Api.Repositories.Interfaces;
using NeonProtocol.Api.Services;
using NeonProtocol.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Neon Protocol API",
        Version = "v1"
    });
});
builder.Services.AddDbContext<NeonProtocolDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IGameSessionRepository, GameSessionRepository>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IGameSessionService, GameSessionService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Neon Protocol API v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
