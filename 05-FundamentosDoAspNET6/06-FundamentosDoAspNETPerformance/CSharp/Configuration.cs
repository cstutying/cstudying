namespace CSharp;

public static class Configuration
{
  public static string JwtKey = "ZmVkYWZlhLMT4xMjM3ODkwCWQyMzQ1Njc4OTA";
  public static string ApiKeyName = "api_key";
  public static string ApiKey = "curso_api_IlTevUG/v0ey3NwCL/unWN==";
  public static SmtpConfiguration Smtp = new();


  public class SmtpConfiguration
  {
    public string Host { get; set; }
    public int Port { get; set; } = 25;
    public string UserName { get; set; }
    public string Password { get; set; }
  }
}