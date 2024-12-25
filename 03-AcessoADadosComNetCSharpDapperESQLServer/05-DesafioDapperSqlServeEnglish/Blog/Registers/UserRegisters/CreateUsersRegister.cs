// TERCEIRO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Registers.UserRegisters;

public static class CreateUsersRegister
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("------------");

    Console.WriteLine("Name: ");
    var name = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Email: ");
    var email = Console.ReadLine();

    Console.WriteLine("Password: ");
    var passwordHash = Console.ReadLine();

    Console.WriteLine("Bio");
    var bio = Console.ReadLine();

    Console.WriteLine("Image: ");
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
      Console.WriteLine("Registered user with success!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to save the User");
      Console.WriteLine(ex.Message);
    }
  }
}