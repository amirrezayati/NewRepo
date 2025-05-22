namespace Endpoint;

public record NotificationRequestDto(string Channel, string Message, string Recipient);
