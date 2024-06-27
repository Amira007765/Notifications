using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class NotificationRepository : INotificationRepository
{
    private readonly ApplicationDbContext _context;

    public NotificationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Notification> GetNotificationsForUser(int userId)
    {
        return _context.Notifications.Where(n => n.UserId == userId).ToList();
    }

    public void AddNotification(Notification notification)
    {
        _context.Notifications.Add(notification);
        _context.SaveChanges();
    }

    public void MarkAsRead(int notificationId)
    {
        var notification = _context.Notifications.Find(notificationId);
        if (notification != null)
        {
            notification.IsRead = true;
            _context.SaveChanges();
        }
    }
}
