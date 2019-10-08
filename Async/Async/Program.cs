using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
   class Program
   {
      static async Task Main(string[] args)
      {
         Console.WriteLine("1: Hello Udemy");
            await LongFunction();
            Console.WriteLine("3: Finish program");

         Thread.Sleep(2000);
      }

      public static async Task LongFunction()
      {
         await Task.Delay(1000);
         Console.WriteLine("2: Finish LongFunction");
      }
   }
}
