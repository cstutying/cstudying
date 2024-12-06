using Cs.NotificationContext;
using static System.Guid;

namespace Cs.SharedContext;

public abstract class Base : Notifiable
{
    public Base()
    {
        Id = NewGuid(); // SPOF
    }

    public Guid Id { get; set; }
}