namespace Endpoint.NotificationSender;

public class WhatsAppSender : INotificationSender
{
    public void Send(string message, string recipient)
    {
        Console.WriteLine($"[WHATSAPP] ارسال به {recipient}: {message}");
    }
}
