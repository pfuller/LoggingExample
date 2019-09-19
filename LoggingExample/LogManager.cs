using System.Reflection;
using System.Diagnostics;
using System;

namespace LoggingExample
{
    public class LogManager
    {
        public static Logger GetLoggerForClass()
        {
            var callerMethod = new StackFrame(1).GetMethod();

            //string className = $"{callerMethod.DeclaringType.FullName}.{callerMethod.Name}";
            string className = $"{callerMethod.DeclaringType.FullName}";

            //// Get call stack
            //StackTrace stackTrace = new StackTrace();

            //foreach(var frame in stackTrace.GetFrames())
            //{
            //    var method = frame.GetMethod();
            //    var declType = method.DeclaringType;

            //    Console.WriteLine($"{declType.FullName}.{method.Name}");
            //}

            //// Get calling method name
            //Console.WriteLine(stackTrace.GetFrame(1).GetMethod().Name);

            return new Logger(className);
        }
    }
}
