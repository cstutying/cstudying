// QUINTO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class DeleteTagScreen
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Exclude Tag Record");
    Console.WriteLine("--------");
    Console.WriteLine("Which tag ID do you want to exclude?:");
    var id = Console.ReadLine();

    Delete(int.Parse(id));
    Console.ReadKey();
    MenuTagScreen.Loading();
  }

  public static void Delete(int id)
  {
    try
    {
      var repository = new Repository<Tag>(Database.Connection);
      repository.Delete(id);
      Console.WriteLine("Tag excluded with success!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to exclude the tag");
      Console.WriteLine(ex.Message);
    }
  }
}