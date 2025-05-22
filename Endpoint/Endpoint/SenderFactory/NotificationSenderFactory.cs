using Endpoint.NotificationSender;

namespace Endpoint.SenderFactory
{
    public class NotificationSenderFactory(IServiceProvider provider) : INotificationSenderFactory
    {
        private readonly IServiceProvider _provider = provider;

        public INotificationSender GetSender(string channel)
        {
            if (string.IsNullOrWhiteSpace(channel))
                throw new ArgumentException("Channel نباید خالی باشد.");

            return channel.ToLower() switch
            {
                "sms" => _provider.GetRequiredService<SmsSender>(),
                //"email" => _provider.GetRequiredService<EmailSender>(),
                //"whatsapp" => _provider.GetRequiredService<WhatsAppSender>(),
                _ => throw new NotSupportedException($"کانال '{channel}' پشتیبانی نمی‌شود.")
            };
        }
    }
}
