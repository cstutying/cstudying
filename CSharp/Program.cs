using CSharp.Data;

var builder = WebApplication.CreateBuilder(args);

// Trabalhar com MVC
builder.Services.AddControllers();
builder.Services.AddDbContext<CSharpDataContext>();

var app = builder.Build();
app.MapControllers();

app.Run();
