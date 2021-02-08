using System;
using System.Threading.Tasks;

namespace MyTest.Interfaces
{
    public abstract class Startable : IStartable
    {
        public abstract Task StartAsync();

        public virtual void WaitEnter()
        {
            Console.ReadLine();
        }
    }
}