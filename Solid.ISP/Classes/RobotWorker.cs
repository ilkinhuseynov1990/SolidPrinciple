using Solid.ISP.Interfaces;
using System;

namespace Solid.ISP.Classes
{
    public class RobotWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
        public void Eat()
        {
            throw new NotImplementedException("Robot does not eat");
        }
        public void Sleep()
        {
            throw new NotImplementedException("Robot does not sleep");
        }
    }
}
