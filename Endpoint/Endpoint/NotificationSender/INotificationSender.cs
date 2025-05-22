namespace Endpoint.NotificationSender
{
    public interface INotificationSender
    {
        void Send(string message, string recipient);
    }
}
