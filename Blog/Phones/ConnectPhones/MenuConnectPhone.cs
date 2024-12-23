namespace Blog.Phones.ConnectPhones
{
  public static class MenuConnectPhone
  {
    public static void Loading()
    {
      Console.Clear();
      Console.WriteLine("Menu Telefônico");
      Console.WriteLine("--------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Lista telefonica");
      Console.WriteLine("2 - Cadastrar Numero");
      Console.WriteLine("3 - Atualizar Numero");
      Console.WriteLine("4 - Excluir Numero");
      Console.WriteLine();
      Console.WriteLine();

      var option = short.Parse(Console.ReadLine()!);
    }
  }
}