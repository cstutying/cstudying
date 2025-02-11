using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;
using CSharp;
using CSharp.Data;
using CSharp.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
ConfigureAuthentication(builder);
ConfigureMvc(builder);
ConfigureServices(builder);


var app = builder.Build();
LoadConfiguration(app);


app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseStaticFiles();
app.Run();


void LoadConfiguration(WebApplication app)
{
  Configuration.JwtKey = app.Configuration.GetValue<string>("JwKey");
  Configuration.ApiKeyName = app.Configuration.GetValue<string>("ApiKeyName");
  Configuration.ApiKey = app.Configuration.GetValue<string>("ApiKey");


// INSTANCIA DA CLASSE SMTP CONFIGURATION (CONFIGURATION.CS)
  var smtp = new Configuration.SmtpConfiguration();
  app.Configuration.GetSection("Smtp").Bind(smtp);
  Configuration.Smtp = smtp;
}


void ConfigureAuthentication(WebApplicationBuilder builder)
{
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
}


void ConfigureMvc(WebApplicationBuilder builder)
{
  builder // WebAplicationBuilder
    .Services // IServiceCollection
    .AddControllers()
    .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; })
    .AddJsonOptions(x =>
    {
      x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
      x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
    });
}


void ConfigureServices(WebApplicationBuilder builder)
{
  builder.Services.AddDbContext<CSharpDataContext>();
  builder.Services.AddTransient<TokenService>();
  builder.Services.AddTransient<EmailService>();
}