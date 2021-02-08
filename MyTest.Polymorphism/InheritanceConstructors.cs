using System;
using MyTest.Interfaces;

namespace MyTestsConsoleApp
{
    public class InheritanceConstructors : StartableTest
    {
        protected override void TestBody()
        {
            var a = new A();
            var b = new B();
            var c = new C();
            I ia = new A();
            I ib = new B();
            I ic = new C();
            
            Console.WriteLine($"{a.P}, {b.P}, {c.P} | {ia.P}, {ib.P}, {ic.P}");
        }

        private interface I
        {
            int P { get; }
        }

        private class A : I
        {
            public virtual int P { get; }

            public A()
            {
                Console.WriteLine($"Class {nameof(A)} created!");
                P = 0;
                Console.WriteLine($"Value of P: {P}");
            }
        }

        private class B : A
        {
            public override int P { get; }

            public B()
            {
                Console.WriteLine($"Class {nameof(B)} created!");
                P = 1;
                Console.WriteLine($"Value of P: {P}");
            }
        }

        private class C : B
        {
            public new int P { get; }

            public C()
            {
                Console.WriteLine($"Class {nameof(C)} created!");
                P = 2;
                Console.WriteLine($"Value of P: {P}");
            }
        }
    }
}