using System;
using System.Threading;
using MyTest.Interfaces;

namespace MyTest.Asynchronous
{
    public class SynchronousMutexThreads:StartableTest
    {
        protected override void TestBody()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }
        }
        
        private Mutex _mutexObj = new Mutex();
        
        private int x = 0;
        private void Count()
        {
            _mutexObj.WaitOne();
            x = 1;
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }

            _mutexObj.ReleaseMutex();
        }
    }
}