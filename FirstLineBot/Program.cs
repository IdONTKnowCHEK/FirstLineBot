using FirstLineBot.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<LineBotApiPracticeContext>(
        options => options.UseMySql("ConnectionString:DefaultConnection", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.1.0-mysql")));

builder.Services.Configure<LineBotSettings>(builder.Configuration.GetSection("LineBot"));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
