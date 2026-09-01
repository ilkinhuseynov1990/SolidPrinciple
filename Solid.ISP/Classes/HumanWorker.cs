using Solid.ISP.Interfaces;
using System;

namespace Solid.ISP.Classes
{
    public class HumanWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Human is working");
        }
        public void Eat()
        {
            Console.WriteLine("Human is eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Human is sleeping");
        }
    }
}
