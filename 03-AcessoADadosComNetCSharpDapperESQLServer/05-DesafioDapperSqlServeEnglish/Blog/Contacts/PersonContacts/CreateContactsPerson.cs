// TERCEIRO MÉTODO CRIADO

using Blog.Models;
using Blog.Repositories;

namespace Blog.Contacts.PersonContacts;

public class CreateContactsPerson
{
  public static void Loading()
  {
    Console.Clear();
    Console.WriteLine("Register New Contact");
    Console.WriteLine("-------------");

    Console.WriteLine("Full Name:: ");
    var name = Console.ReadLine();

    Console.WriteLine("Enter your phone number ");
    var number = Console.ReadLine();

    Console.WriteLine("Enter your email: ");
    var email = Console.ReadLine();

    Console.WriteLine("Enter your Birth Date: ");
    var date = Console.ReadLine();

    Console.WriteLine("Enter your Social Networks: ");
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
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}