public class NotificationService : INotificationService
{
    private readonly INotificationRepository _notificationRepository;

    public NotificationService(INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }

    public void SendNotification(string message, int userId)
    {
        var notification = new Notification
        {
            Message = message,
            DateCreated = DateTime.Now,
            IsRead = false,
            UserId = userId
        };
        _notificationRepository.AddNotification(notification);
    }
}
