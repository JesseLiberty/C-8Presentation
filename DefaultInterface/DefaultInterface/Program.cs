using System;

namespace DefaultInterface
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hello World!");
         var consoleLogger = new ConsoleLogger();
         consoleLogger.Log(2,"General logging");
         //consoleLogger.test(new ConsoleLogger());
      }
   }

   public interface ILogger
   {
      void Log(int level, string message);
    //  void Log(Exception ex) => Log(1, ex.Message); 
   }

   public class ConsoleLogger : ILogger
   {
      public void Log(int level, string message)
      {
         Console.WriteLine($"Logging {message} at level {level}");
      }

      //public void Log(Exception ex)
      //{
      //   Log(2, $"Uh oh.  We got this exception: {ex.Message}");
      //}

      //public void test(ConsoleLogger logger)
      //{
      //   try
      //   {
      //      int x = 5;
      //      int y = 0;
      //      int z = x / y;
      //   }
      //   catch (Exception ex)
      //   {
      //      ILogger iLogger = logger;
      //      iLogger.Log(ex);
      //   }

      //}

   }
}
