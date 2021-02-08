using System;
using MyTest.Asynchronous;
using MyTest.Interfaces;
using MyTestsConsoleApp;

namespace MyTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStartable test = new SynchronousMutexThreads();
            test.StartAsync().Wait();
        }
    }
}