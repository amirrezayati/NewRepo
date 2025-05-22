using Endpoint.SenderFactory;

namespace Endpoint.NotificationService
{
    public class NotificationService(INotificationSenderFactory factory) : INotificationService
    {
        private readonly INotificationSenderFactory _factory = factory;

        public void Notify(string channel, string message, string recipient)
        {
            var sender = _factory.GetSender(channel);
            sender.Send(message, recipient);
        }
    }
}
