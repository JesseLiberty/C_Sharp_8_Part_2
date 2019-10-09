using System;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
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
         try
         {
            Console.WriteLine("Opening file...");
            Console.WriteLine("Entering Run...");
            Divider(6, 2);
            Task.Delay(2000);
            Divider(5, 0);
            Console.WriteLine("Exiting Run...");

         }
         catch (DivideByZeroException e)
         {
            Console.WriteLine(e);

         }
         finally
         {
            Console.WriteLine("Closing file...");

         }
      }

      private int Divider(int top, int bottom)
      {
         if (bottom == 0)
         {
            throw new DivideByZeroException("Don't do that!!'");
         }
         return top / bottom;
      }
   }
}
