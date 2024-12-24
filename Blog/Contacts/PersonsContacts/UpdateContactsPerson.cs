using Blog.Models;
using Blog.Repositories;

namespace Blog.Contacts.PersonsContacts
{
  public static class UpdateContactsPerson
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Atualizar Registro de Contato");
      Console.WriteLine("-----------------------");

      Console.WriteLine("Numero do Id: ");
      var id = Console.ReadLine();

      Console.WriteLine("Nome: ");
      var name = Console.ReadLine();

      Console.WriteLine("Numero de Telefone: ");
      var number = Console.ReadLine();

      Console.WriteLine("Digite seu Email: ");
      var email = Console.ReadLine();

      Console.WriteLine("Digite sua Data de Nascimento: ");
      var date = Console.ReadLine();

      Console.WriteLine("Rede sociais: ");
      var socials = Console.ReadLine();

      Update(new Contact
      {
        Id = int.Parse(id),
        Name = name,
        Number = number,
        Email = email,
        Date = date,
        Socials = socials
      });
      Console.ReadKey();
      MenuContactsPerson.Loading();
    }

    public static void Update(Contact contact)
    {
      try
      {
        var repository = new Repository<Contact>(Database.Connection);
        repository.Update(contact);
        Console.WriteLine("Usuário atualizado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar o Usuário");
        Console.WriteLine(ex.Message);
      }
    }
  }
}