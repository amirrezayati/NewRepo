using Endpoint.NotificationSender;

namespace Endpoint.SenderFactory
{
    public interface INotificationSenderFactory
    {
        INotificationSender GetSender(string channel);
    }
}
