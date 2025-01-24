using CSharp.Data;
using CSharp.Services;

var builder = WebApplication.CreateBuilder(args);

builder // WebAplicationBuilde
  .Services // IServiceCollection
  .AddControllers()
  .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; });


builder.Services.AddDbContext<CSharpDataContext>();
builder.Services.AddTransient<TokenService>();


var app = builder.Build();
app.MapControllers();

app.Run();