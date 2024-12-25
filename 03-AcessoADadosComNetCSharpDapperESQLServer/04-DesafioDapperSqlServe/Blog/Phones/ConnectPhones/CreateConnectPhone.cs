// TERCEIRO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Phones.ConnectPhones
{
  public static class CreateConnectPhone
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Cadastro Numero");
      Console.WriteLine("------------");

      Console.Write("Digite o Numero que deseja Cadastrar: ");
      var number = Console.ReadLine();

      while (true)
      {
        // Verifica se o número contém apenas Números
        if (string.IsNullOrEmpty(number) || !number.All(char.IsDigit))
        {
          Console.WriteLine("Por favor, insira um número válido contendo apenas Números.");
        }
        else
        {
          break; // Sai do loop se o número for válido
        }
      }

      Create(new Phone
      {
        Number = number,
      });
      Console.ReadKey();
      MenuConnectPhone.Loading();
    }

    public static void Create(Phone phone)
    {
      try
      {
        var repository = new Repository<Phone>(Database.Connection);
        repository.Create(phone);
        Console.WriteLine("Cadastrado feito com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível cadastrar!");
        Console.WriteLine(ex.Message);
      }
    }
  }
}