using Solid.DIP.Interfaces;

namespace Solid.DIP.DIP
{
    public class NotificationService
    {
        private readonly INotificationSender _notificationSender;
        public NotificationService(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        public void SendOrderNotification(string customerMessage)
        {
            _notificationSender.Send(customerMessage);
        }
    }
}
