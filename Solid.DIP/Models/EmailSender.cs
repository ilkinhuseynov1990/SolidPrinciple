using Solid.DIP.Interfaces;
using System;

namespace Solid.DIP.Models
{
    public class EmailSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email göndərildi: {message}");
        }
    }
}
