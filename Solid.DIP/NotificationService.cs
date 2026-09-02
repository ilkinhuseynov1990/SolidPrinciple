using System;

namespace Solid.DIP
{
    internal class NotificationService
    {

        private readonly SmsSender _smsSender; // DÜZ ASILILIQ: Konkret klasdan asılıdır

        public NotificationService()
        {
            // ASILILIĞIN QURULMASI: Klass daxilində new olunur
            _smsSender = new SmsSender();
        }


        public void SendOrderNotification(string customerMessage)
        {
            _smsSender.SendSms(customerMessage);
        }
    }
}
