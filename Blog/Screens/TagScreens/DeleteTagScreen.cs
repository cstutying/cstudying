// QUINTO MÉTODO CRIADO
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
  public static class DeleteTagScreen
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Excluir uma tag: ");
      Console.WriteLine("------------");
      Console.WriteLine("Qual o Id da tag que deseja excluir?: ");
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
        Console.WriteLine("Tag excluído com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível excluír a tag");
        Console.WriteLine(ex.Message);
      }
    }
  }
}