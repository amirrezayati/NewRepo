namespace Endpoint.NotificationSender;

public class SmsSender : INotificationSender
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"[SMS] ارسال به {recipient}: {message}");
    }
}
