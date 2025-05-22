namespace Endpoint.NotificationService
{
    public interface INotificationService
    {
        void Notify(string channel, string message, string recipient);
    }
}
