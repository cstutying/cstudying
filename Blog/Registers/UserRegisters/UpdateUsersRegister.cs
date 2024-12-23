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

    Console.WriteLine("Nome: ");
    var name = Console.ReadLine();

    Console.WriteLine("Slug: ");
    var slug = Console.ReadLine();

    Update(new User
    {
      Name = name,
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