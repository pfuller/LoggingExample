using System;

namespace LoggingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassToBeLogged.doStuff();

            Console.WriteLine("Press a key to finish");
            Console.ReadKey();
        }
    }
}
