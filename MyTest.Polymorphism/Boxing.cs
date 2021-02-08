using System;
using System.Threading.Tasks;
using MyTest.Interfaces;

namespace MyTestsConsoleApp
{
    public class Boxing : StartableTest
    {
        protected override void TestBody()
        {
            int i = 5;
            object o = i;
            int j = (int) o;

            Console.WriteLine(object.ReferenceEquals(o, i));//false
            Console.WriteLine(object.Equals(o, i));//false
            Console.WriteLine(o.Equals(i));//true
            Console.WriteLine(o == (object) i);//false
        }
    }
}
