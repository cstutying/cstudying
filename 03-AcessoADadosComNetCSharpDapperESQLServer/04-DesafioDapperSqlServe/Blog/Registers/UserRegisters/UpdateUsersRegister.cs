// QUARTO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Registers.UserRegisters;

public static class UpdateUsersRegister
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Atualizando registros de Usuários");
    Console.WriteLine("-------------");

    Console.WriteLine("Numero do Id: ");
    var id = Console.ReadLine();

    Console.WriteLine("Nome:");
    var name = Console.ReadLine();

    var email = Console.ReadLine();
    Console.WriteLine("Email:");

    var passwordHash = Console.ReadLine();
    Console.WriteLine("Senha: ");

    var bio = Console.ReadLine();
    Console.WriteLine("Bio:");

    var image = Console.ReadLine();
    Console.WriteLine("Imagem:");

    Console.WriteLine("Slug: ");
    var slug = Console.ReadLine();

    Update(new User
    {
      Id = int.Parse(id),
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

  public static void Update(User user)
  {
    try
    {
      var repository = new Repository<User>(Database.Connection);
      repository.Update(user);
      Console.WriteLine("Usuário atualizado com sucesso!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("Não foi possível salvar o Usuário");
      Console.WriteLine(ex.Message);
    }
  }
}