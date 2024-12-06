// LISTAS

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Cs
{
  class Program
  {
    static void Main(string[] args)
    {
      var payments = new List<Payment>();
      // payment.Remove(new Payment()); // Payment.Remove(REMOVE UM ITEMs)
      payments.Add(new Payment(1)); // Payment.Add (ADICIONA UM ITEM)
      payments.Add(new Payment(2)); // Payment.Add (ADICIONA UM ITEM)
      payments.Add(new Payment(3)); // Payment.Add (ADICIONA UM ITEM)
      payments.Add(new Payment(4)); // Payment.Add (ADICIONA UM ITEM)
      payments.Add(new Payment(5)); // Payment.Add (ADICIONA UM ITEM)

      foreach (var item in payments.Skip(2).Take(5)) // IREMOS USAR PARA FAZER PAGINAÇÃO DE DADOS
      {
        Console.WriteLine(item.Id);
      }

      var payment = payments.First(x => x.Id == 3);
      Console.WriteLine(payment.Id);

      // payments.Remove(payment);
      // foreach (var item in payments)
      // {
      //     Console.WriteLine(item.Id);
      // }

      var exists = payments.Count(x => x.Id == 3);
      // var exists = payments.Skip(1); // PULA UM ITEM
      Console.WriteLine(exists);
    }
  }

  public class Payment
  {
    public int Id { get; set; }
    public Payment(int id)
    {
      Id = id;
    }
  }
}
