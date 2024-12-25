// QUARTO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Contacts.PersonContacts;

public static class UpdateContactsPerson
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Update Contract Record");
    Console.WriteLine("-------------");

    Console.WriteLine("ID Number: ");
    var id = Console.ReadLine();

    Console.WriteLine("Name: ");
    var name = Console.ReadLine();

    Console.WriteLine("Telephone Number: ");
    var number = Console.ReadLine();

    Console.WriteLine("Enter your email: ");
    var email = Console.ReadLine();

    Console.WriteLine("Enter your Birth Date: ");
    var date = Console.ReadLine();

    Console.WriteLine("Social Media: ");
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
      Console.WriteLine("User updated with success!");
    }
    catch (Exception ex)
    {
      Console.WriteLine("It was not possible to save the User");
      Console.WriteLine(ex.Message);
    }
  }
}