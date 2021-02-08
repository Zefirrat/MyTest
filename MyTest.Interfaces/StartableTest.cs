using System.Threading.Tasks;

namespace MyTest.Interfaces
{
    public abstract class StartableTest : Startable
    {
        public override Task StartAsync()
        {
            TestBody();
            WaitEnter();
            return Task.CompletedTask;
        }

        protected abstract void TestBody();
    }
}