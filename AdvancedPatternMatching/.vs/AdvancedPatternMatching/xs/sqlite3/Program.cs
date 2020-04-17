using System;

namespace DefaultInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var consoleLogger = new ConsoleLogger();
            consoleLogger.Log(2, "General logging");
            consoleLogger.test();
        }
    }

    public interface ILogger
    {
        void Log(int level, string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(int level, string message)
        {
            Console.WriteLine($"Logging {message} at level {level}");
        }

        public void test()
        {
            try
            {
                int x = 5;
                int y = 0;
                int z = x / y;
            }
            catch (Exception ex)
            {
                Log(1, ex.Message);
            }
        }
    }
}


