using Endpoint;
using Endpoint.NotificationSender;
using Endpoint.NotificationService;
using Endpoint.SenderFactory;

var builder = WebApplication.CreateBuilder(args);

// ثبت وابستگی‌ها
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<INotificationSenderFactory, NotificationSenderFactory>();
builder.Services.AddScoped<SmsSender>(); // در حال حاضر فقط پیامک رجیستر شده است
//builder.Services.AddScoped<EmailSender>(); // ایمیل سنتر
//builder.Services.AddScoped<WhatsAppSender>(); // واتساپ سنتر

var app = builder.Build();

// تعریف یک endpoint برای ارسال پیام نوتیفیکیشن
app.MapPost("/send", (
    NotificationRequestDto request,
    INotificationService notificationService) =>
{
    Console.WriteLine($"[Request] کانال: {request.Channel}, به: {request.Recipient}, متن: {request.Message}");

    notificationService.Notify(request.Channel, request.Message, request.Recipient);

    return Results.Ok($"پیام شما از طریق {request.Channel} ارسال شد.");
});

app.Run();
