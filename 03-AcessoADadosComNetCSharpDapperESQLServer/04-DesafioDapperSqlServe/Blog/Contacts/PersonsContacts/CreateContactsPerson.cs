// TERCEIRO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Contacts.PersonsContacts
{
  public static class CreateContactsPerson
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Cadastrar Novo Contato");
      Console.WriteLine("--------------");

      Console.WriteLine("Nome Completo: ");
      var name = Console.ReadLine();

      Console.WriteLine("Digite seu numero de Telefone: ");
      var number = Console.ReadLine();

      Console.WriteLine("Digite seu Email: ");
      var email = Console.ReadLine();

      Console.WriteLine("Digite sua Data de Nascimento: ");
      var date = Console.ReadLine();

      Console.WriteLine("Digite suas Redes Sociais: ");
      var socials = Console.ReadLine();

      Create(new Contact
      {
        Name = name,
        Number = number,
        Email = email,
        Date = date,
        Socials = socials
      });
      Console.ReadKey();
      MenuContactsPerson.Loading();
    }

    public static void Create(Contact contact)
    {
      try
      {
        var repository = new Repository<Contact>(Database.Connection);
        repository.Create(contact);
        Console.WriteLine("Contato cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível cadastrar esse Contato");
        Console.WriteLine(ex.Message);
      }
    }
  }
}