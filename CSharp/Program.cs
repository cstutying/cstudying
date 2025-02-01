using System.ComponentModel;
using System.Text;
using CSharp;
using CSharp.Data;
using CSharp.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);


var key = Encoding.ASCII.GetBytes(Configuration.JwtKey);
builder.Services.AddAuthentication(x =>
{
  x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
  x.TokenValidationParameters = new TokenValidationParameters
  {
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(key),
    ValidateIssuer = false,
    ValidateAudience = false
  };
});


builder // WebAplicationBuilde
  .Services // IServiceCollection
  .AddControllers()
  .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; });


builder.Services.AddDbContext<CSharpDataContext>();
builder.Services.AddTransient<TokenService>();


var app = builder.Build();


app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();