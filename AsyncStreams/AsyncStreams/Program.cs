using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreams
{
   class Program
   {
      static async Task Main(string[] args)
      {
         await ShowValues();
      }

      public static async IAsyncEnumerable<int> CreateSequence()
      {
         for (int i = 0; i < 20; i++)
         {
            var random = new Random();
            var randomNumber = random.Next(1000);
            await Task.Delay(randomNumber);
            yield return randomNumber;
         }
      }

      public static async Task ShowValues()
      {
         await foreach (var val in CreateSequence())
         {
            Console.WriteLine(val);
         }
      }
   }
}
