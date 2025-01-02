using CSharp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<CSharpDataContext>();

var app = builder.Build();
app.MapControllers();

app.Run();
