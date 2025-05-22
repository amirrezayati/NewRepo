namespace Endpoint.NotificationSender;

public class EmailSender : INotificationSender
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"[EMAIL] ارسال به {recipient}: {message}");
    }
}
