// TERCEIRO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class CreateTagScreen
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Register New Tag");
    Console.WriteLine("---------");

    Console.WriteLine("Name");
    var name = Console.ReadLine();

    Console.WriteLine("Slug");
    var slug = Console.ReadLine();

    Create(new Tag
    {
      Name = name,
      Slug = slug
    });
    Console.ReadKey();
    MenuTagScreen.Loading();
  }

  public static void Create(Tag tag)
  {
    try
    {
      var repository = new Repository<Tag>(Database.Connection);
      repository.Create(tag);
      Console.WriteLine("Tag registered successfully!");
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}