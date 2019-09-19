namespace LoggingExample
{
    public class ClassToBeLogged
    {
        static Logger logger = LogManager.GetLoggerForClass();

        public static void doStuff()
        {
            logger.log("Hello");
        }
    }
}
