using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;

namespace DeferredExecution
{
   class Program
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }
   }

   class Runner
   {
      public void Run()
      {
         var query = Enumerable.Range(0, 1000000)
            .Select(x =>
            {
               Thread.Sleep(1000);
               return x * x;
            });

         foreach (var num in query)
         {
            Console.WriteLine(num);
         }
      }
   }
}
