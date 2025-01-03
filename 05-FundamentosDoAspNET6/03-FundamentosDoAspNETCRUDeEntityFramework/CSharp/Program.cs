using CSharp.Data;

var builder = WebApplication.CreateBuilder(args);

builder // WebAplicationBuilder
  .Services // IServiceCollection
  .AddControllers()
  .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; });

builder.Services.AddDbContext<CSharpDataContext>();

var app = builder.Build();
app.MapControllers();

app.Run();