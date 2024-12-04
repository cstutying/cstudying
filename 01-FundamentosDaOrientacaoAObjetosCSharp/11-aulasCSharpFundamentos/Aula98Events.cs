// EVENTS

namespace Cs;

internal class Program
{
  private static void Main(string[] args)
  {
    var room = new Room(3);
    room.RoomSoldOutEvent += OnRoomSoldOut;

    room.ReserveSeat();
    room.ReserveSeat();
    room.ReserveSeat();
    room.ReserveSeat();
    room.ReserveSeat();
  }

  static void OnRoomSoldOut(object sender, EventArgs eventArgs)
  {
    Console.WriteLine("Sala lotada");
  }
}

public class Room
{
  private int SeatsInUse;
  public Room(int seats) // PARA CRIAR UM MÉTODO DIGITE: "ctor"
  {
    Seats = seats;
    SeatsInUse = 0;
  }

  public int Seats { get; set; }
  public void ReserveSeat()
  {
    SeatsInUse++;
    if (SeatsInUse >= Seats)
      OnRoomSoldOut(EventArgs.Empty);
    else
      Console.WriteLine("Assento Reservado");
  }

  public event EventHandler RoomSoldOutEvent;
  protected virtual void OnRoomSoldOut(EventArgs e)
  {
    var handler = RoomSoldOutEvent;
    handler?.Invoke(this, e);
  }
}