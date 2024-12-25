using Blog.Contacts.PersonContacts;
using Blog.Phones.ConnectPhones;
using Blog.Registers.UserRegisters;
using Blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
  class Program
  {
    private const string CONNECTION_STRING =
      "Server=DESKTOP-ON9P9QD\\SQLEXPRESS;Database=Blog;" +
      "Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main(string[] args)
    {
      Database.Connection = new SqlConnection(CONNECTION_STRING);
      Database.Connection.Open();

      Loading();

      Console.ReadKey();
      Database.Connection.Close();
    }

    private static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Exercício CSHARP");
      Console.WriteLine("--------------");
      Console.WriteLine("What do you want to do?");
      Console.WriteLine();
      Console.WriteLine("1 - User List");
      Console.WriteLine("2 - Telephone List");
      Console.WriteLine("3 - Contact List");
      Console.WriteLine("4 - Tag management");
      Console.WriteLine("5 - Link profile/user");
      Console.WriteLine("6 - Link post/tag");
      Console.WriteLine("7 - Reports");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine()!);

      switch (option)
      {
        case 1:
          MenuUsersRegister.Loading();
          break;
        case 2:
          MenuConnectPhone.Loading();
          break;
        case 3:
          MenuContactsPerson.Loading();
          break;
        case 4:
          MenuTagScreen.Loading();
          break;
        default: Loading(); break;
      }
    }
  }
}