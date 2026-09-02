using System;
using Solid.DIP.Models;

namespace Solid.DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dependency Inversion Pozulmasi
            NotificationService notificationService = new NotificationService();
            notificationService.SendOrderNotification("Your order has been shipped!");
            #endregion



            //Dependency Inversion Qaytarilmasi

            Solid.DIP.DIP.NotificationService notificationService2 = new   Solid.DIP.DIP.NotificationService(new EmailSender());
            notificationService2.SendOrderNotification("Your order has been shipped!");

            Console.ReadLine();
        }
    }
}
