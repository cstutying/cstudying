using System.Collections.Immutable;
using System.ComponentModel;
using System.IO.Compression;
using System.Text;
using System.Text.Json.Serialization;
using CSharp;
using CSharp.Data;
using CSharp.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
ConfigureAuthentication(builder);
ConfigureMvc(builder);
ConfigureServices(builder);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
LoadConfiguration(app);

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseStaticFiles();
app.UseResponseCompression();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

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
  builder.Services.AddMemoryCache();
  builder.Services.AddResponseCompression(options =>
  {
    // options.Providers.Add<BrotliCompressionProvider>();
    options.Providers.Add<GzipCompressionProvider>();
    // options.Providers.Add<CustomCompressionProvider>();
  });
  builder.Services.Configure<GzipCompressionProviderOptions>(options => { options.Level = CompressionLevel.Optimal; });


  builder // WebAplicationBuilde
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
  var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
  builder.Services.AddDbContext<CSharpDataContext>(
    options =>
  options.UseSqlServer(connectionString));
  
  builder.Services.AddTransient<TokenService>();
  builder.Services.AddTransient<EmailService>();
}