using Solid.DIP.Interfaces;
using System;

namespace Solid.DIP.Models
{
    public class WhatsappSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Whatsapp göndərildi: {message}");
        }
    }
}
