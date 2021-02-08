using System;
using MyTest.Interfaces;

namespace MyTestsConsoleApp
{
    public class ReferenceValueType : StartableTest
    {
        protected override void TestBody()
        {
            string alfa = "alfa";
            string beta = "beta";
            Swap(ref alfa, ref beta);

            Console.WriteLine(alfa);
            Console.WriteLine(beta);
        }

        private void Swap(ref string alfa, ref string beta)
        {
            var temp = alfa;
            alfa = beta;
            beta = temp;
        }
    }
}