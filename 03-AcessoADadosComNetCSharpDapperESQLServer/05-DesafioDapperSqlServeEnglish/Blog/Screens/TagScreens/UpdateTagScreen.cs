// QUARTO MÉTODO CRIADO

using Blog.Contacts.PersonContacts;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class UpdateTagScreen
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Update Tag Record");
    Console.WriteLine("-------------");

    Console.WriteLine("Id: ");
    var id = Console.ReadLine();

    Console.WriteLine("Name");
    var name = Console.ReadLine();

    Console.WriteLine("Slug");
    var slug = Console.ReadLine();

    Update(new Tag
    {
      Id = int.Parse(id),
      Name = name,
      Slug = slug
    });
    Console.ReadKey();
    MenuTagScreen.Loading();
  }

  public static void Update(Tag tag)
  {
    try
    {
      var repository = new Repository<Tag>(Database.Connection);
      repository.Update(tag);
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}