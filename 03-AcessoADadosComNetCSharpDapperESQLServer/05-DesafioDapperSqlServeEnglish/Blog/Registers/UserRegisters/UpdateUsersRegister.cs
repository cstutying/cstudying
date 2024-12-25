using Blog.Models;
using Blog.Repositories;

namespace Blog.Registers.UserRegisters;

public class UpdateUsersRegister
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Updating User records");
    Console.WriteLine("------------");

    Console.WriteLine("ID Number:");
    var id = Console.ReadLine();

    Console.WriteLine("Name: ");
    var name = Console.ReadLine();

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
      Console.WriteLine("User updated with success!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to save the User");
      Console.WriteLine(ex.Message);
    }
  }
}