// TERCEIRO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
  public static class CreateTagScreen
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Lista de tags");
      Console.WriteLine("------------");
      Console.WriteLine("Nome: ");
      var name = Console.ReadLine();

      Console.Write("Slug");
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
        Console.WriteLine("Tag cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar a tag");
        Console.WriteLine(ex.Message);
      }
    }
  }
}