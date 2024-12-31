var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
  return Results.Ok("Ola Mundo");
});

app.MapGet("/{nome}", (string nome) =>
{
  return Results.Ok($"Ola {nome}");
});
app.MapPost("/", (User user) =>
{
  return Results.Ok(user);
});

app.Run();

public class User
{
  public int Id { get; set; }
  public string UserName { get; set; }
}