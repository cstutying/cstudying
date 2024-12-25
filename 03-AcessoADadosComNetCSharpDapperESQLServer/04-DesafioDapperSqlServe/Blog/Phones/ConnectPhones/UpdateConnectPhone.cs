// QUARTO MÉTODO CRIADO

using System.Linq.Expressions;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Phones.ConnectPhones
{
  public static class UpdateConnectPhone
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Atualizando registro Telefônico");
      Console.WriteLine("-------------");

      Console.WriteLine("Id: ");
      var id = Console.ReadLine();

      Console.WriteLine("Digite o novo numero que deseja atualizar: ");
      var number = Console.ReadLine();

      Update(new Phone
      {
        Id = int.Parse(id),
        Number = number
      });
      Console.ReadKey();
      MenuConnectPhone.Loading();
    }

    public static void Update(Phone phone)
    {
      try
      {
        var repository = new Repository<Phone>(Database.Connection);
        repository.Update(phone);
        Console.WriteLine("Telefone atualizado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar o Telefone");
        Console.WriteLine(ex.Message);
      }
    }
  }
}