using System;
using MyLibrary;

namespace _Mono_0_HolaMundoConsola
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyClass test = new MyClass();
            Console.WriteLine("Hello {0}", test);

        }
    }
}
