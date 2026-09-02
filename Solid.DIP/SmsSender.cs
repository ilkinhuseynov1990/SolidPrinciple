using System;


namespace Solid.DIP
{
    public class SmsSender
    {
        public void SendSms(string message)
        {
            Console.WriteLine($"SMS göndərildi: {message}");
        }
    }
}
