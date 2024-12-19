using System;
using System.Collections.Generic;

namespace CSharp.Models
{
  public class Career
  {
    public Career()
    {
      Items = new List<CareerItem>();
    }

    public Guid Id { get; set; }
    public string? Title { get; set; }
    public IList<CareerItem> Items { get; set; }
  }
}


    // static void SelectIn(SqlConnection connection)
    // {
    //   var query = @#"select top * from Career where [Id] IN @Id";

    //   var items = connection.Query<Career>(query, new 
    //   {
    //     Id = new []{
    //       "4327ac7e-963b-4893-9f31-9a3b28a4e72b",
    //       "e6730d1c-6870-4df3-ae68-438624e04c72"
    //     }
    //   });
    //   foreach(var item in items){
    //     Console.WriteLine(item.Title);
    //   }
    // }