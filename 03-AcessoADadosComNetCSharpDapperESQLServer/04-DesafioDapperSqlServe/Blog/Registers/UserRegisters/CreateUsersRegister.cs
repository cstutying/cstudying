// TERCEIRO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Registers.UserRegisters
{
  public static class CreateUsersRegister
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("-------");
      Console.WriteLine("Nome: ");

      var name = Console.ReadLine();
      Console.WriteLine("Email: ");

      var email = Console.ReadLine();
      Console.WriteLine("Senha: ");

      var passwordHash = Console.ReadLine();
      Console.WriteLine("Bio: ");

      var bio = Console.ReadLine();
      Console.WriteLine("Imagem: ");

      var image = Console.ReadLine();
      Console.WriteLine("Slug: ");

      var slug = Console.ReadLine();
      Create(new User
      {
        Name = name,
        Email = email,
        PasswordHash = passwordHash,
        Bio = bio,
        Image = image,
        Slug = slug
      });
      Console.ReadKey();
      MenuUsersRegister.Loading();
    }

    public static void Create(User user)
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);
        repository.Create(user);
        Console.WriteLine("Usuário cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar o Usuário");
        Console.WriteLine(ex.Message);
      }
    }
  }
}