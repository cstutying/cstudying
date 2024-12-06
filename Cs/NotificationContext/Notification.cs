namespace Cs.NotificationContext;

public sealed class Notification
{
    public Notification()
    {
    }

    public Notification(string property, string message)
    {
        Property = property;
        Message = Message;
    }

    public string Property { get; set; }
    public string Message { get; set; }
}