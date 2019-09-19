using System;

namespace LoggingExample
{
    public class Logger
    {
        public string LoggerClass { get; set; }

        public Logger(string className)
        {
            this.LoggerClass = className;
        }

        public void log(string message)
        {
            Console.WriteLine($"{LoggerClass} {message}");
        }
    }
}
