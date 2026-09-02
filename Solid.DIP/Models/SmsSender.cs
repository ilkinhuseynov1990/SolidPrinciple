using Solid.DIP.Interfaces;
using System;

namespace Solid.DIP.Models
{
    public class SmsSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS göndərildi: {message}");
        }
    }
}
