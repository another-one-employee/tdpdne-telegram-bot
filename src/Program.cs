using XMinusBot;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<TelegramBot>();

var app = builder.Build();

app.MapControllers();

app.Run();
