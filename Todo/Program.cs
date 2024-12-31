var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // ADICIONOU OS CONTROLLERS

var app = builder.Build();

app.MapControllers(); // MANDOU MAPEAR OS CONTROLLERS

app.Run();