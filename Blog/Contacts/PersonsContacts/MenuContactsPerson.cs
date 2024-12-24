// PRIMEIRO MÉTODO CRIADO

namespace Blog.Contacts.PersonsContacts
{
  public static class MenuContactsPerson
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Menu de Contatos");
      Console.WriteLine("--------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar Todos contato");
      Console.WriteLine("2 - Adicionar um novo contato");
      Console.WriteLine("3 - Atualizar Contato");
      Console.WriteLine("4 - Excluir Contato");
      Console.WriteLine("5 - Sair");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine()!);

      switch (option)
      {
        case 1:
          ListContactsPerson.Loading();
          break;
        case 2:
          CreateContactsPerson.Loading();
          break;
        case 3:
          UpdateContactsPerson.Loading();
          break;
        case 4:
          DeleteContactsPerson.Loading();
          break;
        default: Loading(); break;
      }
    }
  }
}