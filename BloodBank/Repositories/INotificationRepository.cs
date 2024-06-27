using System.Collections.Generic;

public interface INotificationRepository
{
    IEnumerable<Notification> GetNotificationsForUser(int userId);
    void AddNotification(Notification notification);
    void MarkAsRead(int notificationId);
}
