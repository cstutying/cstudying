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


builder // WebAplicationBuilder
  .Services // IServiceCollectio
  .AddControllers()
  .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; });


builder.Services.AddDbContext<CSharpDataContext>();
builder.Services.AddTransient<TokenService>();


var app = builder.Build();
Configuration.JwtKey = app.Configuration.GetValue<string>("JwKey");
Configuration.ApiKeyName = app.Configuration.GetValue<string>("ApiKeyName");
Configuration.ApiKey = app.Configuration.GetValue<string>("ApiKey");


// INSTANCIA DA CLASSE SMTP CONFIGURATION (CONFIGURATION.CS)
var smtp = new Configuration.SmtpConfiguration();
app.Configuration.GetSection("Smtp").Bind(smtp);
Configuration.Smtp = smtp;


app.UseAuthorization();
app.UseAuthentication();


app.MapControllers();


app.Run();