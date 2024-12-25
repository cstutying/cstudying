// SEGUNDO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class ListTagScreen
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("List of Tags");
    Console.WriteLine("------------");
    List();
    Console.ReadKey();
    MenuTagScreen.Loading();
  }

  public static void List()
  {
    var repository = new Repository<Tag>(Database.Connection);
    var tags = repository.Get();
    foreach (var item in tags)
      Console.WriteLine($"{item.Id} - {item.Name} [{item.Slug}]");
  }
}